using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using KYS.UI.Forms.PanelForms;
using KYS.UI.Helpers;
using static KYS.UI.Forms.UserPanelForms.BookDetailForm;

namespace KYS.UI.Forms.UserPanelForms
{
    public partial class BookSearchForm : Form
    {
        private readonly BookService _bookService;
        private readonly BookTypeService _bookTypeService;
        private Form _parentForm;
        public BookSearchForm(Form parentForm)
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _bookService = new BookService(new BookRepository(dbContext));
            _bookTypeService = new BookTypeService(new BookTypeRepository(dbContext));
            _parentForm = parentForm;
        }

        private void BookSearchForm_Load(object sender, EventArgs e)
        {
            LoadTreeView();
            LoadBooks();
        }
        private void LoadTreeView()
        {
            treeViewBookType.Nodes.Clear();

            TreeNode rootNode = new TreeNode("Tüm Türler");
            rootNode.Name = "All";
            treeViewBookType.Nodes.Add(rootNode);

            var bookTypes = _bookTypeService.GetAll();
            foreach (var item in bookTypes)
            {
                TreeNode node = new TreeNode(item.Name)
                {
                    Name = item.Id.ToString()
                };
                rootNode.Nodes.Add(node);
            }

            treeViewBookType.ExpandAll();
        }
        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
            Guid? selectedTypeId = null;

            if (treeViewBookType.SelectedNode != null && treeViewBookType.SelectedNode.Name != "All")
                selectedTypeId = Guid.Parse(treeViewBookType.SelectedNode.Name);
            else
                treeViewBookType.SelectedNode = treeViewBookType.Nodes[0];

            LoadBooks(txtBookSearch.Text, selectedTypeId);
        }
        
        private void treeViewBookType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Guid? selectedTypeId = null;

            if (e.Node.Name != "All")
            {
                selectedTypeId = Guid.Parse(e.Node.Name);
            }

            LoadBooks(txtBookSearch.Text, selectedTypeId);
        }

        private void LoadBooks(string searchBook = "", Guid? selectedTypeId = null)
        {
            flpBooks.Controls.Clear();

            var books = _bookService.GetAll();

            // Tür ID'sine göre filtrele
            if (selectedTypeId != null)
            {
                books = books.Where(b => b.BookTypeID == selectedTypeId).ToList();
            }

            // Arama metnine göre filtrele
            if (!string.IsNullOrEmpty(searchBook))
            {
                books = books.Where(b => b.Name.Contains(searchBook, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var book in books)
            {
                // Kitap paneli
                var bookPanel = new Panel
                {
                    Size = new Size(200, 300),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                // Kitap resmi (PictureBox)
                var bookPicture = new PictureBox
                {
                    ImageLocation = book.CoverImageUrl,
                    Size = new Size(180, 180),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                // Kitap ismi (Label)
                var bookNameLabel = new Label
                {
                    Text = book.Name,
                    AutoSize = false,
                    TextAlign = ContentAlignment.TopCenter,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, 200),
                    Size = new Size(180, 40)
                };

                // Detay butonu (Button)
                var detailsButton = new Button
                {
                    Text = "Detaylar",
                    Size = new Size(180, 30),
                    Location = new Point(10, 250),
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black,
                    FlatStyle = FlatStyle.Flat,
                    Tag=book
                };
                detailsButton.Click += DetailsButton_Click;


                bookPanel.Controls.Add(bookPicture);
                bookPanel.Controls.Add(bookNameLabel);
                bookPanel.Controls.Add(detailsButton);

                flpBooks.Controls.Add(bookPanel);
            }
        }

        private void DetailsButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Book book)
            {
                BookDetailForm newBookDetailForm;

                if (SessionManager.CurrentUser.IsAdmin==true)
                {
                    newBookDetailForm = new BookDetailForm(BookDetailFormMod.Admin)
                    {
                        selectedBook = book
                    };
                }
                else
                {
                    newBookDetailForm = new BookDetailForm(BookDetailFormMod.Register)
                    {
                        selectedBook = book
                    };
                }
                BookDetailUpdate(newBookDetailForm, book);
            }
        }

        private void BookDetailUpdate(BookDetailForm newBookDetailForm, Book selectedBook)
        {

            if (_parentForm is UserPanel userPanel)
            {
                foreach (Form childForm in userPanel.MdiChildren)
                {
                    if (childForm is BookDetailForm bookDetailForm)
                    {
                        bookDetailForm.selectedBook = selectedBook;
                        bookDetailForm.BookDetailUpdate();
                        bookDetailForm.BringToFront();
                        return;
                    }
                }
                newBookDetailForm.MdiParent = userPanel;
                userPanel.ShowFormWithAlignment(newBookDetailForm, false);
                newBookDetailForm.Show();
            }
            else if (_parentForm is AdminPanel adminPanel)
            {
                //adminPanel.ResizeAdminPanel(true);
                adminPanel.ShowBookDetailsInPanel(selectedBook);
            }
        }

    }
}


