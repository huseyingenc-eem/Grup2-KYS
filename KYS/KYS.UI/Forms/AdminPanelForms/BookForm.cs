using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using System.Text;

namespace KYS.UI.Forms
{
    public partial class BookForm : BaseForm
    {
        private readonly AuthorService _authorService;
        private readonly BookTypeService _bookTypeService;
        private readonly PublisherService _publisherService;
        private readonly BookService _bookService;
        public BookForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _authorService = new AuthorService(new AuthorRepository(dbContext));
            _bookTypeService = new BookTypeService(new BookTypeRepository(dbContext));
            _publisherService = new PublisherService(new PublisherRepository(dbContext));
            _bookService = new BookService(new BookRepository(dbContext));

            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            GetAllData();
        }
        private void GetAllData()
        {
            //Yazarlar
            cmbAuthor.ValueMember = "Id";
            cmbAuthor.DisplayMember = "FullName";
            cmbAuthor.DataSource = _authorService.GetAll();
            cmbAuthor.SelectedIndex = -1;

            //Kitap türü
            cmbType.ValueMember = "Id";
            cmbType.DisplayMember = "Name";
            cmbType.DataSource = _bookTypeService.GetAll();
            cmbType.SelectedIndex = -1;

            //yayıncı
            cmbPublisher.ValueMember = "Id";
            cmbPublisher.DisplayMember = "Name";
            cmbPublisher.DataSource = _publisherService.GetAll();
            cmbPublisher.SelectedIndex = -1;

            GetAllBooks();
        }

        Book? secilenKitap;
        private void GetAllBooks()
        {
            lstListe.DisplayMember = "Name";
            lstListe.ValueMember = "Id";
            lstListe.DataSource = _bookService.GetAll();
            lstListe.SelectedIndex = -1;
            secilenKitap = null;
            FormuTemizle();


        }
        private string GenerateRandomISBN()
        {
            Random random = new Random();
            StringBuilder isbnBuilder = new StringBuilder();

            // 13 haneli rastgele sayı oluştur
            for (int i = 0; i < 13; i++)
            {
                isbnBuilder.Append(random.Next(0, 10)); // 0-9 arasında rastgele sayı ekle
            }

            return isbnBuilder.ToString();
        }
        private void FormuTemizle()
        {
            txtPublishedYear.Text = "";
            txtPages.Text = "";
            txtISBN.Text = GenerateRandomISBN();
            txtDescription.Text = "";
            txtCopiesAvailable.Text = "";
            txtLanguage.Text = "";
            cmbAuthor.SelectedIndex = -1;
            cmbPublisher.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
            pictureBoxPhoto.ImageLocation = null;
            txtName.Text = "";
            txtName.Focus();
        }
        Author? selectedAuthor;
        private void cmbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthor.SelectedIndex != -1)
            {
                selectedAuthor = (Author?)cmbAuthor.SelectedItem;
            }
        }

        BookType? selectedBookType;
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex != -1)
            {
                selectedBookType = (BookType?)cmbType.SelectedItem;
            }
        }

        Publisher? selectedPublisher;
        private void cmbPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPublisher.SelectedIndex != -1)
            {
                selectedPublisher = (Publisher?)cmbPublisher.SelectedItem;
            }
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_bookService.IfEntityExists(a=>a.CoverImageUrl == pictureBoxPhoto.ImageLocation))
                {
                    secilenKitap = (Book?)lstListe.SelectedItem;
                    throw new Exception("Bu ISBN veya fotoğraf zaten başka bir kitapta kullanılıyor!");
                }
                Book newBook = new Book()
                {
                    Name = txtName.Text,
                    PublishedYear = Convert.ToInt32(txtPublishedYear.Text),
                    Pages = Convert.ToInt32(txtPages.Text),
                    CopiesAvailable = Convert.ToInt32(txtCopiesAvailable.Text),
                    Description = txtDescription.Text,
                    Language = txtLanguage.Text,
                    Author = selectedAuthor,
                    BookType = selectedBookType,
                    Publisher = selectedPublisher,
                    CoverImageUrl = pictureBoxPhoto.ImageLocation,

                };
                lblLocation.Text = newBook.ShelfLocation;
                _bookService.Create(newBook);
                MessageBox.Show("Kayıt Başarılı");
                GetAllBooks();
                FormuTemizle();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenKitap != null)
                {
                    _bookService.Delete(secilenKitap.Id);
                    GetAllBooks();
                    MessageBox.Show("İşlem Başarılı");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstListe.SelectedIndex == -1)
                    throw new Exception("Listeden Kitap seçiniz.");

                if (_bookService.IfEntityExists(a => (a.CoverImageUrl == pictureBoxPhoto.ImageLocation) && a.Id != secilenKitap.Id))
                {
                    secilenKitap = (Book?)lstListe.SelectedItem;
                    pictureBoxPhoto.ImageLocation = secilenKitap?.CoverImageUrl;
                    throw new Exception("Bu ISBN veya fotoğraf zaten başka bir kitapta kullanılıyor!");
                }

                if (secilenKitap != null)
                {
                    secilenKitap.Name = txtName.Text;
                    secilenKitap.PublishedYear = Convert.ToInt32(txtPublishedYear.Text);

                    secilenKitap.Pages = Convert.ToInt32(txtPages.Text);
                    secilenKitap.CopiesAvailable = Convert.ToInt32(txtCopiesAvailable.Text);
                    secilenKitap.Description = txtDescription.Text;
                    secilenKitap.Language = txtLanguage.Text;
                    if (selectedAuthor != null)
                    {
                        secilenKitap.Author = selectedAuthor;
                    }
                    if (selectedPublisher != null)
                    {
                        secilenKitap.Publisher = selectedPublisher;
                    }
                    if (selectedBookType != null)
                    {
                        secilenKitap.BookType = selectedBookType;
                    }

                    secilenKitap.CoverImageUrl = pictureBoxPhoto.ImageLocation;

                    _bookService.Update(secilenKitap);
                    MessageBox.Show("Güncelleme işlemi başarılı");
                    GetAllBooks();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex != -1)
            {
                secilenKitap = (Book?)lstListe.SelectedItem;

                if (secilenKitap != null)
                {
                    txtName.Text = secilenKitap.Name;
                    txtPublishedYear.Text = secilenKitap.PublishedYear.ToString();
                    txtPages.Text = secilenKitap.Pages.ToString();
                    txtCopiesAvailable.Text = secilenKitap.CopiesAvailable.ToString();
                    txtDescription.Text = secilenKitap.Description;
                    txtLanguage.Text = secilenKitap.Language;
                    pictureBoxPhoto.ImageLocation = secilenKitap.CoverImageUrl;
                    cmbAuthor.SelectedValue = secilenKitap.AuthorID;
                    cmbType.SelectedValue = secilenKitap.BookTypeID;
                    cmbPublisher.SelectedValue = secilenKitap.PublisherID;
                }
            }
        }

        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Fotoğraf Seç";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Proje klasöründe 'Resources/Images' dizinini oluştur
                    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory; // Çalışma dizini
                    string imageFolderPath = Path.Combine(projectDirectory, "Resources", "Images");

                    if (!Directory.Exists(imageFolderPath))
                    {
                        Directory.CreateDirectory(imageFolderPath); // Klasör yoksa oluştur
                    }

                    // Seçilen resmin yeni yolunu belirle
                    string newImagePath = Path.Combine(imageFolderPath, Path.GetFileName(openFileDialog.FileName));

                    // Resmi hedef klasöre kopyala
                    File.Copy(openFileDialog.FileName, newImagePath, true);

                    // PictureBox'ta yeni resmi göster
                    pictureBoxPhoto.ImageLocation = newImagePath;

                    MessageBox.Show($"Resim başarıyla eklendi: {newImagePath}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pictureBoxPhoto_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBoxPhoto.Image == null) // Eğer resim yoksa yazı göster
            {
                string text = "Resim eklemek için tıklayınız";
                Font font = new Font("Arial", 15, FontStyle.Bold);
                SizeF textSize = e.Graphics.MeasureString(text, font);

                // Yazıyı PictureBox'ın ortasına hizala
                float x = (pictureBoxPhoto.Width - textSize.Width) / 2;
                float y = (pictureBoxPhoto.Height - textSize.Height) / 2;

                e.Graphics.DrawString(text, font, Brushes.Gray, x, y);
            }
        }
    }
}
