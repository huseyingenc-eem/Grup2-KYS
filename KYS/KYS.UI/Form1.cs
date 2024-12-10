using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
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
            var dbContext = new ApplicationDBContext();
            _userService = userService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                // Kullanýcýyý doðrula
                var user = _userService.Authenticate(username, password);
                SessionManager.CurrentUser = user;
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
                adminPanel.Show();
            }
            else
            {
                var userPanel = Program.ServiceProvider.GetRequiredService<UserPanel>();
                userPanel.Show();
            }

            this.Hide();
        }

        private void lnkCreateAccout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (UserForm registerForm = new UserForm(UserFormMode.Register))
            {
                this.Hide(); // Form1'i gizle
                registerForm.ShowDialog(); // UserForm'u modal olarak aç
                this.Show(); // UserForm kapandýktan sonra Form1'i tekrar göster
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
