using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using KYS.UI.Forms.PanelForms;
using KYS.UI.Helpers;
using System.Data;

namespace KYS.UI.Forms.UserPanelForms
{
    public partial class BookDetailForm : Form
    {
        private readonly CommentService _commentService;


        public Book? selectedBook { get; set; }
        public enum BookDetailFormMod
        {
            Register,
            Admin
        }
        private BookDetailFormMod _currentMode;
        public BookDetailForm(BookDetailFormMod mode)
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _commentService = new CommentService(new CommentRepository(dbContext));

            _currentMode= mode;
            if (mode == BookDetailFormMod.Register)
            {
                btnBorrowBook.Visible = true;
            }
            else if (mode == BookDetailFormMod.Admin)
            {
                btnBorrowBook.Visible = false;
            }
        }
        

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            BookDetailUpdate();
        }

        public void BookDetailUpdate()
        {
            if (selectedBook != null)
            {
                lblBookName.Text = selectedBook.Name ?? "Belirtilmemiş";
                pictureBoxCover.ImageLocation = selectedBook.CoverImageUrl;
                lblLocation.Text=selectedBook.ShelfLocation;
                lblBookType.Text = selectedBook.BookType?.Name ?? "Belirtilmemiş";
                lblAuthor.Text = selectedBook.Author?.Name ?? "Belirtilmemiş";
                lblPublisherName.Text = selectedBook.Publisher?.Name ?? "Belirtilmemiş";
                lblLocation.Text = selectedBook.ShelfLocation;
                lblPublisherYear.Text = selectedBook.PublishedYear.ToString();
                lblBookPage.Text = selectedBook.Pages.ToString();
                lblCopiesAvailable.Text = selectedBook.CopiesAvailable.ToString();
                txtBookDescription.Text = selectedBook.Description ?? string.Empty;

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
                    Size = new Size(flpComments.Width - 10, 100),
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
                if (_currentMode == BookDetailFormMod.Admin || SessionManager.CurrentUser?.Id == comment.UserID)
                {
                    var deleteButton = new Button
                    {
                        Text = "Sil",
                        Size = new Size(50, 25),
                        Font = new Font("Arial", 9, FontStyle.Regular),
                        Location = new Point(commentPanel.Width - 60, commentPanel.Height - 35),
                        BackColor = Color.Red,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat
                    };

                    // Silme işlemi için butonun Click olayını tanımla
                    deleteButton.Click += (s, e) =>
                    {
                        var confirmResult = MessageBox.Show("Bu yorumunuzu silmek istediğinizden emin misiniz?",
                            "Yorumu Sil",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (confirmResult == DialogResult.Yes)
                        {
                            _commentService.Delete(comment.Id);
                            LoadComments(bookId); // Yorumları yeniden yükle
                        }
                    };
                    commentPanel.Controls.Add(deleteButton);
                }
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
                Comment newComment = new Comment
                {
                    BookID = selectedBook.Id,
                    UserID = SessionManager.CurrentUser.Id,
                    Content = txtCommentContent.Text,
                    CreatedDate = DateTime.Now
                };

                _commentService.Create(newComment);

                MessageBox.Show("Yorum başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadComments(selectedBook.Id);
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

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            if (selectedBook.AvailabilityStatus == false)
            {
                MessageBox.Show($"Kütüphanede Kitap Kalmadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            BorrowRecordForm borrowRecordForm = new BorrowRecordForm()
            {
                borrowBook=selectedBook,
            };
            borrowRecordForm.StartPosition = FormStartPosition.CenterScreen;
            borrowRecordForm.ShowDialog();

            
        }
    }
}
