using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;

namespace KYS.UI.Forms
{
    public partial class BookForm : BaseForm
    {
        private readonly AutorService _authorService;
        private readonly BookTypeService _bookTypeService;
        private readonly PublisherService _publisherService;
        private readonly BookService _bookService;
        private readonly ApplicationDBContext _dbContext;
        public BookForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDBContext();
            var authorRepository = new AuthorRepository(_dbContext);
            var bookTypeRepository = new BookTypeRepository(_dbContext);
            var publisherRepository = new PublisherRepository(_dbContext);
            var bookRepository = new BookRepository(_dbContext);
            _authorService = new AutorService(authorRepository);
            _bookTypeService = new BookTypeService(bookTypeRepository);
            _publisherService = new PublisherService(publisherRepository);
            _bookService = new BookService(bookRepository);

            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            CheckControl();
            GetAllData();
        }

        private void CheckControl()
        {
            chckMevcutMu.Text = chckMevcutMu.Checked ? "Kitap Mevcut" : "Kitap Bulunmamakta";
        }

        private void GetAllData()
        {
            //Yazarlar
            cmbAuthor.ValueMember = "Id";
            cmbAuthor.DisplayMember = "FullName";
            cmbAuthor.DataSource = _authorService.GetAll();

            //Kitap türü
            cmbType.ValueMember = "Id";
            cmbType.DisplayMember = "Name";
            cmbType.DataSource = _bookTypeService.GetAll();

            //yayıncı
            cmbPublisher.ValueMember = "Id";
            cmbPublisher.DisplayMember = "Name";
            cmbPublisher.DataSource = _publisherService.GetAll();

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
                Book b = new Book()
                {
                    Name = txtName.Text,
                    ISBN = txtISBN.Text,
                    PublishedYear = Convert.ToInt32(txtPublishedYear.Text),
                    Pages = Convert.ToInt32(txtPages.Text),
                    CopiesAvailable = Convert.ToInt32(txtCopiesAvailable.Text),
                    Description = txtDescription.Text,
                    Language = txtLanguage.Text,
                    Author = selectedAuthor,
                    BookType = selectedBookType,
                    Publisher = selectedPublisher,
                    CoverImageUrl = pictureBoxPhoto.ImageLocation,
                    AvailabilityStatus = chckMevcutMu.Checked
                };
                if (_bookService.IfEntityExists(a => a.Name == b.Name))
                {
                    throw new Exception("Bu Kitap Daha Önce Kaydedilmiş");
                }
                _bookService.Create(b);
                MessageBox.Show("Kayıt Başarılı");
                GetAllBooks();
                FormuTemizle();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormuTemizle()
        {
            txtPublishedYear.Text = "";
            txtPages.Text = "";
            txtISBN.Text = "";
            txtDescription.Text = "";
            txtCopiesAvailable.Text = "";
            txtLanguage.Text = "";
            if (cmbAuthor.Items.Count > 0)
                cmbAuthor.SelectedIndex = 0;

            if (cmbPublisher.Items.Count > 0)
                cmbPublisher.SelectedIndex = 0;

            if (cmbType.Items.Count > 0)
                cmbType.SelectedIndex = 0;

            chckMevcutMu.Checked = false;
            pictureBoxPhoto.ImageLocation = null;
            txtName.Text = "";
            txtName.Focus();
        }

        private void chckMevcutMu_CheckedChanged(object sender, EventArgs e)
        {
            CheckControl();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = " Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Fotoğraf Seç";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPhoto.ImageLocation = openFileDialog.FileName;
                }
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
                if (secilenKitap != null)
                {
                    secilenKitap.Name = txtName.Text;
                    secilenKitap.ISBN = txtISBN.Text;
                    secilenKitap.PublishedYear=Convert.ToInt32(txtPublishedYear.Text);
                    secilenKitap.Pages=Convert.ToInt32(txtPages.Text);
                    secilenKitap.CopiesAvailable=Convert.ToInt32(txtCopiesAvailable.Text);
                    secilenKitap.Description=txtDescription.Text;
                    secilenKitap.Language=txtLanguage.Text;
                    secilenKitap.AvailabilityStatus=chckMevcutMu.Checked;
                    secilenKitap.Author = selectedAuthor;
                    secilenKitap.Publisher=selectedPublisher;
                    secilenKitap.BookType=selectedBookType;
                    secilenKitap.CoverImageUrl = pictureBoxPhoto.ImageLocation;

                    _bookService.Update(secilenKitap);
                    MessageBox.Show("Güncelleme işlemi başarılı");
                    GetAllBooks();
                }
                else
                {
                    MessageBox.Show("Lütfen bir şirket seçiniz");
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
                    txtISBN.Text = secilenKitap.ISBN;
                    txtPublishedYear.Text=secilenKitap.PublishedYear.ToString();
                    txtPages.Text = secilenKitap.Pages.ToString();
                    txtCopiesAvailable.Text = secilenKitap.CopiesAvailable.ToString();
                    txtDescription.Text = secilenKitap.Description;
                    txtLanguage.Text = secilenKitap.Language;
                    pictureBoxPhoto.ImageLocation = secilenKitap.CoverImageUrl;
                    // Yazar bilgisi ComboBox'ta seç
                    if (secilenKitap.Author != null)
                    {
                        cmbAuthor.SelectedValue = secilenKitap.Author.Id;
                    }

                    // Kitap türü bilgisi ComboBox'ta seç
                    if (secilenKitap.BookType != null)
                    {
                        cmbType.SelectedValue = secilenKitap.BookType.Id;
                    }

                    // Yayıncı bilgisi ComboBox'ta seç
                    if (secilenKitap.Publisher != null)
                    {
                        cmbPublisher.SelectedValue = secilenKitap.Publisher.Id;
                    }
                    chckMevcutMu.Checked = secilenKitap.AvailabilityStatus;
                }
            }
        }
    }
}
