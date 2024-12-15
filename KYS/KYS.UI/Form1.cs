using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.Entities.Models;
using KYS.UI.Forms;
using KYS.UI.Forms.PanelForms;
using KYS.UI.Helpers;
using Microsoft.Extensions.DependencyInjection;
using static KYS.UI.Forms.UserForm;

namespace KYS.UI
{

    public partial class Form1 : Form
    {
        private readonly UserService _userService;


        public Form1(UserService userService)
        {
            InitializeComponent();
            this.CenterToScreen();
            //var dbContext = new ApplicationDBContext();
            _userService = userService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SessionManager.LoadSession();

            if (SessionManager.CurrentUser != null)
            {
                NavigateToPanel(SessionManager.CurrentUser);
                this.Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                var user = _userService.Authenticate(username, password);
                SessionManager.CurrentUser = user;
                SessionManager.SaveSession();
                NavigateToPanel(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Giriþ Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NavigateToPanel(User user)
        {
            if (user.IsAdmin)
            {
                var adminPanel = Program.ServiceProvider.GetRequiredService<AdminPanel>();
                adminPanel.ShowDialog();
            }
            else
            {
                var userPanel = Program.ServiceProvider.GetRequiredService<UserPanel>();
                userPanel.ShowDialog();
            }

            this.Hide();
        }

        private void lnkCreateAccout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (UserForm registerForm = new UserForm(UserFormMode.Register))
            {
                this.Hide();
                registerForm.StartPosition=FormStartPosition.CenterScreen;
                registerForm.ShowDialog();
                
                this.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.SaveSession();
        }
    }
}
