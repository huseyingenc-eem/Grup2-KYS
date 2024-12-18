using System.Data;
using System.Windows.Forms;
using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.Entities.Models;
using KYS.UI.Forms.UserPanelForms;
using KYS.UI.Helpers;
using Microsoft.Data.SqlClient;
using static KYS.UI.Forms.UserPanelForms.BookDetailForm;
using System.Drawing;
using System.Windows.Forms;
using KYS.UI.Forms.AdminPanelForms;

namespace KYS.UI.Forms.PanelForms
{
    public partial class AdminPanel : Form
    {
        private readonly UserService _userService;
        private readonly ApplicationDBContext _context;

        public AdminPanel(UserService userService, ApplicationDBContext context)
        {
            InitializeComponent();
            _userService = userService;
            _context = context;

            LoadYazarSayisi();
            LoadKitapTurSayisi();
            LoadDuyuruSayisi();
            LoadKullaniciSayisi();
            LoadYayinciSayisi();
            LoadKitapSayisi();

            menuStrip1.Renderer = new CustomMenuRenderer();
        }
        public class CustomMenuRenderer : ToolStripProfessionalRenderer
        {
            //protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            //{
            //    base.OnRenderMenuItemBackground(e);

            //    if (e.Item.Owner is MenuStrip)
            //    {
            //        e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(Point.Empty, e.Item.Size));
            //    }
            //    else if (e.Item.OwnerItem != null)
            //    {
            //        e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(Point.Empty, e.Item.Size));
            //    }
            //}

            //protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            //{
            //    base.OnRenderItemText(e);
            //    e.TextColor = Color.White;
            //}
        }
        private void LoadKitapSayisi()
        {
            try
            {
                int kitapSayisi = _context.Books.Count();
                lblBook.Text = $"Kitap Sayısı: {kitapSayisi}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadYayinciSayisi()
        {
            try
            {
                int yayinciSayisi = _context.Publishers.Count();
                lblPublisher.Text = $"Yayıncı Sayısı: {yayinciSayisi}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKullaniciSayisi()
        {
            try
            {
                int kullaniciSayisi = _context.Users.Count();
                lblUser.Text = $"Kullanıcı Sayısı: {kullaniciSayisi}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDuyuruSayisi()
        {
            try
            {
                int duyuruSayisi = _context.Duyurular.Count();
                lblAnnouncement.Text = $"Duyuru Sayısı: {duyuruSayisi}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKitapTurSayisi()
        {
            try
            {
                int turSayisi = _context.BookTypes.Count();
                lblType.Text = $"Kitap Tür Sayısı: {turSayisi}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadYazarSayisi()
        {
            try
            {
                int yazarSayisi = _context.Authors.Count();
                lblAuthor.Text = $"Yazar Sayısı: {yazarSayisi}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AdminPanel_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            // Eğer oturum yoksa çıkış yap
            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Oturumunuz sona erdi. Lütfen tekrar giriş yapın.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
                return;
            }
            adSoyadToolStripMenuItem.Text = $"Hoş geldiniz, {SessionManager.CurrentUser?.Name}";
            this.Width = _collapsedAdminPanelWidth;
        }


        private void ShowFormInPanel(Form childForm, string sectionName)
        {
            // Açık olan formu kapat
            CloseCurrentFormInPanel();

            // Paneli temizle
            pnlForms.Controls.Clear();
            lblHeader.Text = sectionName;
            // Yeni formu ekle ve göster
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;

            pnlForms.Controls.Add(childForm);
            childForm.Show();
        }

        private void CloseCurrentFormInPanel()
        {
            this.Width=_collapsedAdminPanelWidth;
            // pnlForms içindeki tüm kontrolleri kontrol et
            foreach (Control control in pnlForms.Controls)
            {
                if (control is Form form)
                {
                    form.Close(); // Açık olan formu kapat
                    break; // Tek bir form var, dolayısıyla döngüden çık
                }
            }
        }


        private void kullanıcıTakipEtmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            ShowFormInPanel(userForm,"Kullanıcı Takip Etme");
        }
        private void kitapAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSearchForm bookSearchForm = new BookSearchForm(this);
            ShowFormInPanel(bookSearchForm,"Kitap Arama Ekranı");
        }
        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            ShowFormInPanel(bookForm,"Kitap Ekle");
        }

        private void türEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookTypeForm bookTypeForm = new BookTypeForm();
            ShowFormInPanel(bookTypeForm,"Tür Ekle");
        }
        private void yazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorform authorForm = new Authorform();
            ShowFormInPanel(authorForm,"Yazar Ekle");
        }
        private void yayıncıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublisherForm publisherForm = new PublisherForm();
            ShowFormInPanel(publisherForm,"Yayıncı Ekle");
        }

        private void duyuruEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnnouncementForm announcementForm = new AnnouncementForm();
            ShowFormInPanel(announcementForm,"Duyuru Ekle");
        }

        private void adminBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            ShowFormInPanel(profileForm,"Admin Bilgileri");
        }

        private void ödünçAlınanKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AdminBorrowRecord adminBorrowRecord = new AdminBorrowRecord();
            ShowFormInPanel(adminBorrowRecord,"Ödünç kitap Ekranı");
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionManager.ClearSession();
            Application.Restart();
        }
        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void ShowBookDetailsInPanel(Book book)
        {
            pnlYardimci.Controls.Clear(); // Paneli temizle

            // Yeni BookDetailForm oluştur ve parametreyi ayarla
            BookDetailForm detailForm = new BookDetailForm(BookDetailFormMod.Admin)
            {
                selectedBook = book
            };

            // Form ayarları
            detailForm.TopLevel = false;
            detailForm.Dock = DockStyle.Fill;
            detailForm.FormBorderStyle = FormBorderStyle.None;
            this.Width = _defaultAdminPanelWidth;
            pnlYardimci.Controls.Add(detailForm); // Panel içine ekle
            detailForm.Show();
        }
        private int _defaultAdminPanelWidth = 2200; // Varsayılan genişlik
        private int _collapsedAdminPanelWidth = 1389; // Küçültülecek genişlik

    }
}
