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
            lblWelcome.Text = $"Hoş geldiniz, {SessionManager.CurrentUser?.Name} {SessionManager.CurrentUser?.Surname}";
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
