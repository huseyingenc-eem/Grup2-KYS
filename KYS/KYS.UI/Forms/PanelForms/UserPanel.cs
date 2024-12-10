using KYS.UI.Forms.UserPanelForms;
using KYS.UI.Helpers;

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
            adSoyadToolStripMenuItem.Text = $"Hoş geldiniz, {SessionManager.CurrentUser?.Name} {SessionManager.CurrentUser?.Surname}";
        }


        private void FormControl(Form frm)
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
                MessageBox.Show("Form Zaten Açık duurmda");
            else
                frm.Show();
        }
        private void kitapHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDetailForm bookDetailForm = new BookDetailForm();
            bookDetailForm.MdiParent = this;
            FormControl(bookDetailForm);
        }
        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ödünçAldığımKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yazarBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorDetailsForm authorDetailsForm = new AuthorDetailsForm();
            authorDetailsForm.MdiParent = this;
            FormControl(authorDetailsForm);
        }

        private void kullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profilForm=new ProfileForm();
            profilForm.MdiParent = this;
            FormControl(profilForm);

        }
    }
}
