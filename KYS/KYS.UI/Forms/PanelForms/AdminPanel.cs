using KYS.Business.Services;
using KYS.UI.Forms.UserPanelForms;
using KYS.UI.Helpers;

namespace KYS.UI.Forms.PanelForms
{
    public partial class AdminPanel : Form
    {
        private readonly UserService _userService;

        public AdminPanel(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            adSoyadToolStripMenuItem.Text = $"Hoş geldiniz, {SessionManager.CurrentUser?.Name}";
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
        private void kullanıcıTakipEtmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.MdiParent = this;
            FormControl(userForm);
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.MdiParent = this;
            FormControl(bookForm);
        }

        private void türEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookTypeForm bookTypeForm = new BookTypeForm();
            bookTypeForm.MdiParent = this;
            FormControl(bookTypeForm);
        }

        private void duyuruEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnnouncementForm announcementForm = new AnnouncementForm();
            announcementForm.MdiParent = this;
            FormControl(announcementForm);
        }

        private void yayıncıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PublisherForm publisherForm = new PublisherForm();
            publisherForm.MdiParent = this;
            FormControl(publisherForm);
        }
    }
}
