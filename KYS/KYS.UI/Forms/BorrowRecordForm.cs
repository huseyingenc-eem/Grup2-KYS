using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using KYS.UI.Helpers;

namespace KYS.UI.Forms
{
    public partial class BorrowRecordForm : Form
    {
        private readonly BorrowRecordService _borrowRecordService;
        private readonly UserService _userService;
        private readonly BookService _bookService;
        public Book? borrowBook;

        User currentUser = SessionManager.CurrentUser;

        private const int _defaultBorrowDuration = 14;

        public BorrowRecordForm()
        {
            InitializeComponent();
            var dBContext = new ApplicationDBContext();
            _borrowRecordService = new BorrowRecordService(new BorrowRecordRepository(dBContext));
            _userService=new UserService(new UserRepository(dBContext));
            _bookService=new BookService(new BookRepository(dBContext));
        }

        private void BorrowRecordForm_Load(object sender, EventArgs e)
        {

            if (borrowBook != null)
            {
                txtBookName.Text = borrowBook.Name;
                txtAuthorName.Text = borrowBook.Author.Name;
                pictureBoxPhoto.ImageLocation = borrowBook.CoverImageUrl;
            }

            if (currentUser != null)
            {
                txtUserName.Text = currentUser.FullName;
            }
            dtpBorrowDate.Value = DateTime.Now;
            dtpBorrowDate.Enabled = false;

            dtpReturnDate.Value = DateTime.Now.AddDays(_defaultBorrowDuration);
            dtpReturnDate.Enabled = false;
            // Ödünç alma tarihini ve mesajı ayarla
            dtpBorrowDate.Value = DateTime.Now;
            lblMessage.Text = $"Bu kitabı {_defaultBorrowDuration} gün içinde iade etmelisiniz!";

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (borrowBook == null || currentUser == null)
                {
                    MessageBox.Show("Kitap veya kullanıcı bilgileri eksik!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (currentUser.MaxBorrowLimit <= 0)
                {
                    throw new Exception("Kitap ödünç alamazsınız çünkü ödünç alma hakkınız kalmadı!");
                }
                var existingRecord = _borrowRecordService.GetAll()
                    .FirstOrDefault(r => r.UserID == currentUser.Id && r.BookID == borrowBook.Id && r.Status == "Borrowed");

                if (existingRecord != null)
                {
                    throw new Exception("Bu kitabı zaten ödünç aldınız! Aynı kitabı birden fazla ödünç alamazsınız.");
                }
                var borrowRecord = new BorrowRecord
                {
                    BookID = borrowBook.Id,
                    UserID = currentUser.Id,
                    
                };

                _borrowRecordService.Create(borrowRecord);

                currentUser.MaxBorrowLimit--;
                _userService.Update(currentUser);

                borrowBook.CopiesAvailable--;
                _bookService.Update(borrowBook);
                MessageBox.Show("Kayıt başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bu işlemi iptal etmek istediğinizden emin misiniz?",
                                 "İptal Onayı",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

}

        
