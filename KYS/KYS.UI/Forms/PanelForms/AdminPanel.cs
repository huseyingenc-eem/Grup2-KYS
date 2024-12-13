using System.Data;
using System.Windows.Forms;
using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.Entities.Models;
using KYS.UI.Forms.UserPanelForms;
using KYS.UI.Helpers;
using Microsoft.Data.SqlClient;
using static KYS.UI.Forms.UserPanelForms.BookDetailForm;

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
        }


        
        private void ShowChildForm(Form childForm)
        {
            bool acikMi = false;

            // Açık olan formları kontrol et
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == childForm.GetType())
                {
                    acikMi = true;
                    item.Activate(); // Açık olan formu etkinleştir
                    item.BringToFront(); // Formu ön plana getir
                    break;
                }
            }
            foreach (Control control in this.Controls)
            {
                if (!(control is MdiClient) && !(control is MenuStrip)) // MDI Container ve MenuStrip hariç
                {
                    control.Visible = false; // Tüm diğer kontrolleri gizle
                }
            }
            if (!acikMi)
            {
                childForm.FormClosed += AdminPanel_MdiChildFormClosed;
                childForm.MdiParent = this;
                childForm.TopMost = true;
                childForm.Show();
            }
            else
                MessageBox.Show("Form zaten açık durumda.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AdminPanel_MdiChildFormClosed(object? sender, FormClosedEventArgs e)
        {
            // Admin Panel'deki gizlenen kontrolleri tekrar görünür yap
            foreach (Control control in this.Controls)
            {
                if (!(control is MdiClient)) // Sadece MDI Container hariç
                {
                    control.Visible = true; // Kontrolleri göster
                }
            }
        }

        public void ShowFormWithAlignment(Form frm, bool isLeftAligned)
        {
            frm.StartPosition = FormStartPosition.Manual;

            // MDI Parent genişlik ve yükseklik bilgilerini al
            int parentWidth = this.ClientSize.Width;
            int parentHeight = this.ClientSize.Height;

            // Formun genişlik ve yüksekliği
            int formWidth = frm.Width;
            int formHeight = frm.Height;

            // X koordinatını belirle
            int x = isLeftAligned
                ? 2 // Sola yaslı, girintili
                : parentWidth - formWidth - 10; // Sağa yaslı, girintili

            // Y koordinatını ortalamak için hesapla
            int y = (parentHeight - formHeight) - (parentHeight - formHeight - 10);

            // Formun konumunu ayarla
            frm.Location = new Point(x, y);
        }
        private void kullanıcıTakipEtmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            ShowFormWithAlignment(userForm, true);
            ShowChildForm(userForm);
        }
        private void kitapAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSearchForm bookSearchForm = new BookSearchForm();
            ShowFormWithAlignment(bookSearchForm, true);
            ShowChildForm(bookSearchForm);
        }
        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            ShowFormWithAlignment(bookForm, true);
            ShowChildForm(bookForm);
        }

        private void türEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookTypeForm bookTypeForm = new BookTypeForm();
            ShowFormWithAlignment(bookTypeForm, true);
            ShowChildForm(bookTypeForm);
        }
        private void yazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorform authorForm = new Authorform();
            ShowFormWithAlignment(authorForm, true);
            ShowChildForm(authorForm);
        }
        private void yayıncıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublisherForm publisherForm = new PublisherForm();
            ShowFormWithAlignment(publisherForm, true);
            ShowChildForm(publisherForm);
        }

        private void duyuruEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnnouncementForm announcementForm = new AnnouncementForm();
            ShowFormWithAlignment(announcementForm, true);
            ShowChildForm(announcementForm);
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

        private void adminBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            ShowFormWithAlignment(profileForm, false);
            ShowChildForm(profileForm);
        }

        private void ExportaData(List<User> users)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Verileri Dışa Aktar";
                    saveFileDialog.DefaultExt = "xlsx";
                    saveFileDialog.AddExtension = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Örnek veri (herhangi bir tip olabilir)
                        var userList = _userService.GetAll().Cast<object>().ToList();

                        if (filePath.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
                        {
                            GenericExporter.ExportToExcel(userList, filePath);
                            MessageBox.Show("Veriler Excel olarak dışa aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
