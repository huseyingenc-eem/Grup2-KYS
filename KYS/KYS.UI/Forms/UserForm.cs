using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using User = KYS.Entities.Models.User;

namespace KYS.UI.Forms
{
    public partial class UserForm : Form
    {
        private List<User> users = new List<User>();
        private readonly UserService _userService;
        private readonly UserRepository _userRepository;
        public UserForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _userRepository = new UserRepository(dbContext);
            _userService = new UserService(_userRepository);
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtSurname.Text) ||
                    string.IsNullOrWhiteSpace(txtUserName.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    throw new Exception("Tüm alanları doldurmanız gerekiyor.");
                }

                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Geçerli bir e-posta adresi girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User newUser = new User
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    Username = txtUserName.Text,
                    Password = txtPassword.Text, 
                    Email = txtEmail.Text,
                    MaxBorrowLimit = (int)numLimit.Value
                };

                users.Add(newUser);
                LoadUsers();
                ClearForm();

                MessageBox.Show("Kullanıcı başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsers()
        {
            lstUsers.DataSource = null;
            lstUsers.DataSource = users;
            lstUsers.DisplayMember = "Username";
        }
        private void ClearForm()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            numLimit.Value = 1;
            txtName.Focus();
        }
        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItem != null)
            {
                User selectedUser = (User)lstUsers.SelectedItem;
                txtName.Text = selectedUser.Name;
                txtSurname.Text = selectedUser.Surname;
                txtUserName.Text = selectedUser.Username;
                txtPassword.Text = selectedUser.Password;
                txtEmail.Text = selectedUser.Email;
                numLimit.Value = selectedUser.MaxBorrowLimit;
                
            }
        }
    }  
     
         
}
