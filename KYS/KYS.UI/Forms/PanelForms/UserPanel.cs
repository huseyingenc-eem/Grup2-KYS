using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.UI.Forms.UserPanelForms;
using KYS.UI.Helpers;
using static KYS.UI.Forms.UserPanelForms.BookDetailForm;
using System.Drawing;
using System.Windows.Forms;

namespace KYS.UI.Forms.PanelForms
{
    public partial class UserPanel : Form
    {
        private readonly DuyurularService _duyurularService;
        public UserPanel()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _duyurularService = new DuyurularService(new DuyurularRepository(dbContext));
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Oturumunuz sona erdi. Lütfen tekrar giriş yapın.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
                return;
            }
            adSoyadToolStripMenuItem.Text = $"Hoş geldiniz, {SessionManager.CurrentUser?.Name} {SessionManager.CurrentUser?.Surname}";

            LoadAnnouncements();

            menuStrip1.Renderer = new CustomMenuRenderer();
        }

        public class CustomMenuRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                base.OnRenderMenuItemBackground(e);

                if (e.Item.Owner is MenuStrip)
                {
                    e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(Point.Empty, e.Item.Size));
                }
                else if (e.Item.OwnerItem != null)
                {
                    e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(Point.Empty, e.Item.Size));
                }
            }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                base.OnRenderItemText(e);
                e.TextColor = Color.White;
            }
        }

        public void FormControl(Form frm)
        {
            bool acikMi = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == frm.GetType())
                {
                    acikMi = true;
                    openForm.Activate(); // Mevcut formu etkinleştir
                    openForm.BringToFront(); // Formu ön plana getir
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
            if (acikMi)
            {
                MessageBox.Show("Form Zaten Açık duurmda");
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (!(control is MdiClient) && !(control is MenuStrip)) // MDI Container ve MenuStrip hariç
                    {
                        control.Visible = false; // Tüm diğer kontrolleri gizle
                    }
                }
                frm.FormClosed += UserPanelChildFormClosed; ;
                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void UserPanelChildFormClosed(object? sender, FormClosedEventArgs e)
        {
            if (this.MdiChildren.Length == 1)
            {
                foreach (Control control in this.Controls)
                {
                    if (!(control is MdiClient) && !(control is MenuStrip)) // Sadece MDI Container hariç
                    {
                        control.Visible = true;
                    }
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
        private void kitapAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSearchForm bookSearch = new BookSearchForm(this);
            bookSearch.MdiParent = this;

            ShowFormWithAlignment(bookSearch, true);
            FormControl(bookSearch);

        }
        private void kitapHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDetailForm bookDetailForm = new BookDetailForm(BookDetailFormMod.Register);
            bookDetailForm.MdiParent = this;
            ShowFormWithAlignment(bookDetailForm, false);
            FormControl(bookDetailForm);

        }


        private void yazarBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorDetailsForm authorDetailsForm = new AuthorDetailsForm();
            authorDetailsForm.MdiParent = this;
            ShowFormWithAlignment(authorDetailsForm, true);
            FormControl(authorDetailsForm);
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profilForm = new ProfileForm();
            profilForm.MdiParent = this;
            ShowFormWithAlignment(profilForm, false);
            FormControl(profilForm);


        }
        private void yaptığımYorumlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyCommentForm myCommentForm = new MyCommentForm();
            myCommentForm.MdiParent = this;
            ShowFormWithAlignment(myCommentForm, false);
            FormControl(myCommentForm);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionManager.ClearSession();
            Application.Restart();
        }
        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ödünçAlmaEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowRecordForm borrowRecordForm = new BorrowRecordForm();
            borrowRecordForm.MdiParent = this;
            ShowFormWithAlignment(borrowRecordForm, false);
            FormControl(borrowRecordForm);
        }

        private void ödünçAldığımKitaplarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                MyBorrowRecord myBorrowRecord = new MyBorrowRecord();
                myBorrowRecord.MdiParent = this;

                ShowFormWithAlignment(myBorrowRecord, false);
                FormControl(myBorrowRecord);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }

        }

        private void LoadAnnouncements()
        {
            var currentScrollPosition = flpAnnouncements.VerticalScroll.Value;

            // Mevcut duyuruları temizle
            flpAnnouncements.Controls.Clear();

            // Duyuruları veritabanından al
            var announcements = _duyurularService.GetAll()
                .OrderByDescending(a => a.CreatedDate)
                .ToList();

            foreach (var announcement in announcements)
            {
                // Duyuru paneli
                var announcementPanel = new Panel
                {
                    Size = new Size(flpAnnouncements.Width - 10, 100),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(3),
                    Padding = new Padding(5)
                };

                // Duyuru başlık label'ı (Sol üstte yaslı)
                var titleLabel = new Label
                {
                    Text = announcement.Baslik,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(5, 5) // Sol üst köşe
                };

                // Tarih label'ı (Sağ üst köşe)
                var dateLabel = new Label
                {
                    Text = $"{announcement.CreatedDate:dd.MM.yyyy HH:mm}",
                    Font = new Font("Arial", 8, FontStyle.Regular),
                    AutoSize = true,
                    Location = new Point(announcementPanel.Width - 105, 5),
                    TextAlign = ContentAlignment.TopRight
                };

                // Duyuru içeriği label'ı (Başlık altında)
                var contentLabel = new Label
                {
                    Text = announcement.Icerik,
                    Font = new Font("Arial", 9, FontStyle.Regular),
                    AutoSize = false,
                    Size = new Size(announcementPanel.Width - 20, 50),
                    Location = new Point(15, 30)
                };

                // Panellere label'ları ekle
                announcementPanel.Controls.Add(titleLabel);
                announcementPanel.Controls.Add(dateLabel);
                announcementPanel.Controls.Add(contentLabel);

                // Paneli FlowLayoutPanel'e ekle
                flpAnnouncements.Controls.Add(announcementPanel);
            }

            // Scroll pozisyonunu geri yükle
            flpAnnouncements.VerticalScroll.Value = currentScrollPosition;
            flpAnnouncements.PerformLayout();
        }
    }
}
