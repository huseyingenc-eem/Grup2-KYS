using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;

namespace KYS.UI.Forms.UserPanelForms
{
    public partial class ProfileForm : Form
    {
        private readonly UserService _userService;
        private User _currentUser; 
        public ProfileForm(UserService userService, User currentUser)
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _userService = userService;
            _currentUser = currentUser;

            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            txtName.Text = _currentUser.Name;
            txtSurname.Text = _currentUser.Surname;
            txtUserName.Text = _currentUser.Username;
            txtEmail.Text = _currentUser.Email;
            txtPassword.Text = _currentUser.Password;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
           
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _currentUser.Name = txtName.Text;
                _currentUser.Surname = txtSurname.Text;
                _currentUser.Username = txtUserName.Text;
                _currentUser.Email = txtEmail.Text;
                _currentUser.Password = txtPassword.Text;

                _userService.Update(_currentUser);
               

                MessageBox.Show("Bilgileriniz başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
