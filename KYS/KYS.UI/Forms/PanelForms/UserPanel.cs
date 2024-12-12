using KYS.UI.Forms.UserPanelForms;
using KYS.UI.Helpers;
using static KYS.UI.Forms.UserPanelForms.BookDetailForm;

namespace KYS.UI.Forms.PanelForms
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
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
        }


        public void FormControl(Form frm)
        {
            bool acikMi = false;
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == frm.GetType())
                {
                    acikMi = true;
                    break;
                }
            }
            if (acikMi)
            {
                MessageBox.Show("Form Zaten Açık duurmda");
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
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
            BookSearchForm bookSearch = new BookSearchForm();
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

        private void ödünçAldığımKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
