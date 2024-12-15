using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using KYS.UI.Forms.PanelForms;
using KYS.UI.Forms.UserPanelForms;
using KYS.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static KYS.UI.Forms.UserPanelForms.BookDetailForm;

namespace KYS.UI.Forms
{
    public partial class AuthorDetailsForm : Form
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly AuthorService _autorService;
        private readonly BookService _bookService;
        public AuthorDetailsForm()
        {
            InitializeComponent();

            _dbContext = new ApplicationDBContext();
            AuthorRepository authorrepository = new AuthorRepository(_dbContext);
            BookRepository bookRepository = new BookRepository(_dbContext);

            _autorService = new AuthorService(authorrepository);
            _bookService = new BookService(bookRepository);
        }

        private void AuthorDetailsForm_Load(object sender, EventArgs e)
        {
            lstYazar.SelectedIndexChanged -= lstYazar_SelectedIndexChanged;
            GetAllAuthorBySearchText(string.Empty);
            lstYazar.SelectedIndexChanged += lstYazar_SelectedIndexChanged;

        }
        Author? secilenYazar;
        private void GetAllAuthorBySearchText(string searchText)
        {
            if (!string.IsNullOrEmpty(searchText.ToLower()) && searchText.Length >= 3)
            {
                //yazarları filtreye göre fetirelim
                var authorList = _autorService.GetAll().Where(a => a.FullName.ToLower().Contains(searchText.ToLower()));

                lstYazar.ValueMember = "Id";
                lstYazar.DisplayMember = "FullName";
                lstYazar.DataSource = authorList.ToList();
            }
            else if (searchText.Length <= 2)
            {
                lstYazar.ValueMember = "Id";
                lstYazar.DisplayMember = "FullName";
                lstYazar.DataSource = _autorService.GetAll().ToList();
                lstYazar.SelectedIndex = -1;
            }
        }
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            GetAllAuthorBySearchText(txtAra.Text);
        }
        private void lstYazar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstYazar.SelectedIndex != -1)
            {
                secilenYazar = (Author?)lstYazar.SelectedItem;
                if (secilenYazar != null)
                {
                    lblFullName.Text = secilenYazar.FullName ?? "Belirtilmemiştir";
                    lblDogumTarih.Text = secilenYazar.BirthDate.HasValue
                        ? secilenYazar.BirthDate.Value.ToString("dd.MM.yyyy")
                        : "Belirtilmemiştir";
                    lblUlke.Text = secilenYazar.Country ?? "Belirtilmemiştir";
                    lblBiografy.Text = secilenYazar.Biography ?? "Belirtilmemiştir";
                    pictureBox1.ImageLocation = secilenYazar.PhotoUrl;

                    lstKitap.DisplayMember = "Name";
                    lstKitap.ValueMember = "Id";
                    lstKitap.DataSource = _bookService.GetAll()
                        .Where(book => book.AuthorID == secilenYazar.Id)
                        .ToList();
                    lstKitap.SelectedIndex = -1;
                }

            }

        }
        Book? secilenKitap;
        bool butonaTiklandiMi;
        private void lstKitap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKitap.SelectedIndex != -1)
            {
                secilenKitap = (Book?)lstKitap.SelectedItem;
            }
            if (butonaTiklandiMi == true)
            {
                SecilenBook();
            }


        }
        private void btnSendToBook_Click(object sender, EventArgs e)
        {
            SecilenBook();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (this.GetChildAtPoint(e.Location) == null)
            {
                FormuTemizle();
            }
        }

        private void FormuTemizle()
        {
            lblBiografy.Text = "";
            lblUlke.Text = "";
            lblDogumTarih.Text = "";
            pictureBox1.ImageLocation = null;
            lstKitap.DataSource = null; // Listeyi temizlemek için
            hoveredIndex = -1;
            clickedIndex = -1;
            lstYazar.Invalidate();
            hovered2Index = -1;
            clicked2Index = -1;
            lstKitap.Invalidate();
            lblFullName.Text = "";
            lblFullName.Focus();
        }

        private void SecilenBook()
        {
            if (secilenKitap == null)
            {
                MessageBox.Show("Lütfen bir kitap seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BookDetailForm newBookDetailForm;

            if (SessionManager.CurrentUser.IsAdmin == true)
            {
                newBookDetailForm = new BookDetailForm(BookDetailFormMod.Admin)
                {
                    selectedBook = secilenKitap
                };
            }
            else
            {
                newBookDetailForm = new BookDetailForm(BookDetailFormMod.Register)
                {
                    selectedBook = secilenKitap
                };
            }
            BookDetailUpdate(newBookDetailForm, secilenKitap);
            butonaTiklandiMi = true;
        }

        private void BookDetailUpdate(BookDetailForm newBookDetailForm, Book selectedBook)
        {

            if (this.MdiParent is UserPanel userPanel)
            {

                // Zaten açık bir BookDetailForm var mı kontrol et
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is BookDetailForm bookDetailForm)
                    {
                        // Açık olan formu güncelle
                        bookDetailForm.selectedBook = selectedBook;
                        bookDetailForm.BookDetailUpdate();
                        bookDetailForm.BringToFront();
                        return;
                    }
                }
                userPanel.ShowFormWithAlignment(newBookDetailForm, false);
                newBookDetailForm.MdiParent = this.MdiParent;
                newBookDetailForm.Show();
            }
            if (this.MdiParent is AdminPanel adminPanel)
            {

                // Zaten açık bir BookDetailForm var mı kontrol et
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is BookDetailForm bookDetailForm)
                    {
                        // Açık olan formu güncelle
                        bookDetailForm.selectedBook = selectedBook;
                        bookDetailForm.BookDetailUpdate();
                        bookDetailForm.BringToFront();
                        return;
                    }
                }
                adminPanel.ShowFormWithAlignment(newBookDetailForm, false);
                newBookDetailForm.MdiParent = this.MdiParent;
                newBookDetailForm.Show();
            }
        }
        private int hoveredIndex = -1;
        private int clickedIndex = -1;

        private void lstYazar_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Color backColor = Color.White;
            Color textColor = Color.Black;

            if (e.Index == hoveredIndex)
                backColor = Color.LightSteelBlue;

            if (e.Index == clickedIndex)
                backColor = Color.LightBlue;

            e.DrawBackground();
            using (Brush brush = new SolidBrush(backColor))
                e.Graphics.FillRectangle(brush, e.Bounds);

            using (Brush textBrush = new SolidBrush(textColor))
            {
                var item = lstYazar.Items[e.Index] as Author;
                string text = item != null ? item.FullName : "Bilinmeyen";
                e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void lstYazar_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lstYazar.IndexFromPoint(e.Location);
            if (index != hoveredIndex)
            {
                hoveredIndex = index;
                lstYazar.Invalidate();
            }
        }

        private void lstYazar_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lstYazar.IndexFromPoint(e.Location);
            if (index >= 0)
            {
                clickedIndex = index;
                lstYazar.Invalidate();
            }
        }


        private int hovered2Index = -1;
        private int clicked2Index = -1;
        private void lstKitap_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Color backColor = Color.White;
            Color textColor = Color.Black;

            if (e.Index == hoveredIndex)
                backColor = Color.LightSteelBlue;

            if (e.Index == clickedIndex)
                backColor = Color.LightBlue;

            e.DrawBackground();
            using (Brush brush = new SolidBrush(backColor))
                e.Graphics.FillRectangle(brush, e.Bounds);

            using (Brush textBrush = new SolidBrush(textColor))
            {
                var item = lstKitap.Items[e.Index] as Book;
                string text = item != null ? item.Name : "Bilinmeyen";
                e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void lstKitap_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lstKitap.IndexFromPoint(e.Location);
            if (index != hoveredIndex)
            {
                hoveredIndex = index;
                lstKitap.Invalidate();
            }
        }

        private void lstKitap_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lstKitap.IndexFromPoint(e.Location);
            if (index >= 0)
            {
                clickedIndex = index;
                lstKitap.Invalidate();
            }
        }
    }
}
