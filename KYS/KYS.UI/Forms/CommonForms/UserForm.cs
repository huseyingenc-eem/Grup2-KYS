using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using KYS.UI.Helpers;
using User = KYS.Entities.Models.User;

namespace KYS.UI.Forms
{

    public partial class UserForm : Form
    {
        private readonly UserService _userService;

        // Mod Tanımlama
        public enum UserFormMode
        {
            Register,
            Admin
        }

        private UserFormMode _currentMode;

        public UserForm(UserFormMode mode)
        {
            InitializeComponent();
            var dbContext = new ApplicationDBContext();
            _userService = new UserService(new UserRepository(dbContext));

            _currentMode = mode;

            if (mode == UserFormMode.Register)
            {
                // Register modunda kullanıcı listesi gizli ve sadece kayıt aktif
                lstUsers.Visible = false;
                btnGüncelle.Visible = false;
                btnSil.Visible = false;

                btnKaydet.Text = "Kayıt Ol";
                this.Size = new Size(600, 500);

            }
            else if (mode == UserFormMode.Admin)
            {
                // Admin modunda listeleme, düzenleme ve kayıt aktif
                lstUsers.Visible = true;
                btnGüncelle.Visible = true;
                btnSil.Visible = true;
                txtPassword.ReadOnly = true;
                btnKaydet.Text = "Kullanıcı Ekle";
                this.Size = new Size(1000, 700);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        public UserForm() : this(UserFormMode.Admin) { }
        private void LoadUsers()
        {
            Guid currentAdminId = SessionManager.CurrentUser.Id;

            var users = _userService.GetAll()
                .Where(u => u.Id != currentAdminId)
                .ToList();
            lstUsers.ValueMember = "Id";
            lstUsers.DisplayMember = "FullName";
            lstUsers.DataSource = users;

        }
        private void ClearForm()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            hoveredIndex = -1;
            clickedIndex = -1;
            lstUsers.Invalidate();
            txtEmail.Text = string.Empty;
            txtName.Focus();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                if (_userService
                    .IfEntityExists(x => x.Username == txtUserName.Text ||
                                    x.Email == txtEmail.Text)
                    )
                    throw new Exception($"{txtUserName.Text} bu kullanıcı adı yada email kullanılıyor.");

                User newUser = new User
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    Username = txtUserName.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                };

                _userService.Create(newUser);

                if (lstUsers.Visible == true)
                    MessageBox.Show("Kullanıcı başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Başarıyla kayıt oldunuz. Yönlendiriliyorsunuz.", "Giriş Yapmak İçin Basınız.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int hoveredIndex = -1;   // Mouse ile üzerine gelinen öğe
        private int clickedIndex = -1;   // Tıklanan öğe


        User? selectedUser;
        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstUsers.SelectedItem != null)
            {
                selectedUser = (User)lstUsers.SelectedItem;

                txtName.Text = selectedUser.Name;
                txtSurname.Text = selectedUser.Surname;
                txtUserName.Text = selectedUser.Username;
                txtPassword.Text = selectedUser.Password;
                txtEmail.Text = selectedUser.Email;
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (this.GetChildAtPoint(e.Location) == null)
            {
                ClearForm();
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {

                if (_userService
                    .IfEntityExists(x => x.Username == txtUserName.Text ||
                                    x.Email == txtEmail.Text))
                {
                    selectedUser = (User?)lstUsers.SelectedItem;
                    txtEmail.Text = selectedUser?.Email;
                    txtUserName.Text = selectedUser?.Username;
                    throw new Exception($"{txtUserName.Text} bu kullanıcı adı yada email kullanılıyor.");

                }

                if (selectedUser != null)
                {
                    selectedUser.Name = txtName.Text;
                    selectedUser.Surname = txtSurname.Text;
                    selectedUser.Username = txtUserName.Text;
                    selectedUser.Email = txtEmail.Text;

                }
                _userService.Update(selectedUser);
                MessageBox.Show("Güncelleme İşlemi Başarılı.");
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUser != null)
                    _userService.Delete(selectedUser.Id);

                LoadUsers();
                MessageBox.Show("Silme İşlemi Başarılı.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstUsers_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Color backColor = Color.White;
            Color textColor = Color.Black;

            if (e.Index == hoveredIndex)
                backColor = Color.LightSteelBlue;

            if (e.Index == clickedIndex)
                backColor = Color.LightBlue;

            e.DrawBackground();
            using (Brush brush = new SolidBrush(backColor))
                e.Graphics.FillRectangle(brush, e.Bounds);

            using (Brush textBrush = new SolidBrush(textColor))
            {
                var item = lstUsers.Items[e.Index] as User;
                string text = item != null ? item.FullName : "Bilinmeyen";
                e.Graphics.DrawString(text, e.Font, textBrush, e.Bounds);
            }

            e.DrawFocusRectangle();
        }

        private void lstUsers_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lstUsers.IndexFromPoint(e.Location);
            if (index != hoveredIndex)
            {
                hoveredIndex = index;
                lstUsers.Invalidate(); // ListBox'ı yeniden çiz
            }
        }

        private void lstUsers_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lstUsers.IndexFromPoint(e.Location);
            if (index >= 0)
            {
                clickedIndex = index;
                lstUsers.Invalidate(); // ListBox'ı yeniden çiz
            }
        }
    }


}
