using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using KYS.UI.Helpers;
using System.Data;
using System.Net;

namespace KYS.UI.Forms.UserPanelForms
{
    public partial class BookDetailForm : Form
    {
        private readonly BookService _bookService;
        private readonly BookRepository _bookRepository;

        private readonly BookTypeService _bookTypeService;

        private readonly AuthorService _authorService;

        private readonly PublisherService _publisherService;

        private readonly CommentService _commentService;

        public BookDetailForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _bookRepository = new BookRepository(dbContext);
            _bookService = new BookService(_bookRepository);
            _authorService = new AuthorService(new AuthorRepository(dbContext));
            _bookTypeService = new BookTypeService(new BookTypeRepository(dbContext));
            _publisherService = new PublisherService(new PublisherRepository(dbContext));
            _commentService = new CommentService(new CommentRepository(dbContext));
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            FilterBooksInComboBox(string.Empty);

        }

        private void FilterBooksInComboBox(string searchText)
        {
            if (!string.IsNullOrEmpty(searchText.ToLower()) && searchText.Length >= 3)
            {
                var bookList = _bookService.GetAll()
                    .Where(book => book.Name.ToLower().Contains(searchText.ToLower()))
                    .ToList();

                lstBookListele.ValueMember = "Id";
                lstBookListele.DisplayMember = "Name";
                lstBookListele.DataSource = bookList;
                lstBookListele.SelectedIndex = -1;
            }
            else if (searchText.Length <= 2)
            {
                lstBookListele.ValueMember = "Id";
                lstBookListele.DisplayMember = "Name";
                lstBookListele.DataSource = _bookService.GetAll().ToList();
                lstBookListele.SelectedIndex = -1;
            }
        }

        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
            FilterBooksInComboBox(txtBookSearch.Text);
        }

        Book? selectedBook;

        private void lstBookListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBookListele.SelectedIndex != -1)
            {
                selectedBook = (Book?)lstBookListele.SelectedItem;

                if (selectedBook != null)
                {
                    lblBookName.Text = selectedBook.Name ?? "Belirtilmemiş";
                    pictureBoxCover.ImageLocation = selectedBook.CoverImageUrl;
                    lblISBN.Text = selectedBook.ISBN ?? "Belirtilmemiş";

                    lblBookType.Text = selectedBook.BookType?.Name;
                    lblAuthor.Text = selectedBook.Author?.Name;
                    lblPublisherName.Text = selectedBook.Publisher?.Name;

                    lblPublisherYear.Text = selectedBook.PublishedYear.ToString();
                    lblBookPage.Text = selectedBook.Pages.ToString();
                    lblCopiesAvailable.Text = selectedBook.CopiesAvailable.ToString();
                    txtBookDescription.Text = selectedBook.Description ?? string.Empty;
                }

                LoadComments(selectedBook.Id);
            }
        }

        private void LoadComments(Guid bookId)
        {
            var currentScrollPosition = flpComments.VerticalScroll.Value;

            flpComments.Controls.Clear();

            var comments = _commentService.GetAll()
                .Where(c => c.BookID == bookId)
                .OrderByDescending(c => c.CreatedDate)
                .ToList();

            foreach (var comment in comments)
            {
                // Yorumun temel paneli
                var commentPanel = new Panel
                {
                    Size = new Size(flpComments.Width - 20, 100),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(3),
                    Padding = new Padding(5)
                };

                // Kullanıcı adı label'ı (Sol üstte yaslı)
                var userLabel = new Label
                {
                    Text = $"{comment.User?.Name} {comment.User?.Surname}",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(5, 5), // Sol üstte yaslı
                };

                // Tarih label'ı (Sağ üstte yaslı)
                var dateLabel = new Label
                {
                    Text = $"{comment.CreatedDate:HH:mm - dd.MM.yyyy}",
                    Font = new Font("Arial", 8, FontStyle.Regular),
                    AutoSize = true,
                    Location = new Point(commentPanel.Width - 105, 5),
                    TextAlign = ContentAlignment.TopRight,
                };

                // Yorum içeriği label'ı (Alt satırda, girintili)
                var contentLabel = new Label
                {
                    Text = comment.Content,
                    Font = new Font("Arial", 9, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(commentPanel.Width - 20, 40),
                    Location = new Point(15, 30),
                };

                commentPanel.Controls.Add(userLabel);
                commentPanel.Controls.Add(dateLabel);
                commentPanel.Controls.Add(contentLabel);

                // FlowLayoutPanel'e paneli ekle
                flpComments.Controls.Add(commentPanel);
            }
            flpComments.VerticalScroll.Value = currentScrollPosition;
            flpComments.PerformLayout();
        }


        private void btnSubmitComment_Click(object sender, EventArgs e)
        {


            try
            {
                //SessionManager.CurrentUser.Id
                var newComment = new Comment
                {
                    BookID = selectedBook.Id,
                    UserID = SessionManager.CurrentUser.Id,
                    Content = txtCommentContent.Text,
                    CreatedDate = DateTime.Now
                };

                _commentService.Create(newComment);

                MessageBox.Show("Yorum başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadComments(selectedBook.Id);
                // Form elemanlarını temizle
                txtCommentContent.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yorum eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
