using KYS.Business.Services;
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
            lblWelcome.Text = $"Hoş geldiniz, {SessionManager.CurrentUser?.Name}";

        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
