using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using KYS.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYS.UI.Forms.AdminPanelForms
{
    public partial class AdminBorrowRecord : Form
    {
        private readonly BorrowRecordService _borrowRecordService;
        private readonly BookService _bookService;
        private readonly UserService _userService;

        public AdminBorrowRecord()
        {
            InitializeComponent();
            var dBContext = new ApplicationDBContext();
            _borrowRecordService = new BorrowRecordService(new BorrowRecordRepository(dBContext));
            _bookService = new BookService(new BookRepository(dBContext));
            _userService = new UserService(new UserRepository(new ApplicationDBContext()));
        }




        private void AdminBorrowRecord_Load(object sender, EventArgs e)
        {
            cmbSearch.SelectedIndex = 0;
            
            grbRecord.Visible = true;
            grbKullanici.Visible = false;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            {
                string searchText = txtSearch.Text.Trim();
                var records = _borrowRecordService.GetAll(); // Tüm kayıtları getir

                // Eğer arama metni 3 karakterden azsa tüm kayıtları göster.
                if (string.IsNullOrEmpty(searchText) || searchText.Length < 3)
                {
                    BindToDataGrid(records);
                    return;
                }

                // Eğer arama metni 3 veya daha fazla karakterse, filtrelenmiş kayıtları göster.
                var filteredRecords = records.Where(r =>
                    (r.Book?.Name != null && r.Book.Name.StartsWith(searchText, StringComparison.OrdinalIgnoreCase)) ||
                    (r.User?.Name != null && r.User.Name.StartsWith(searchText, StringComparison.OrdinalIgnoreCase))
                );

                BindToDataGrid(filteredRecords);
            }
        }
        private void BindToDataGrid(IEnumerable<BorrowRecord> records)
        {
            dgvBorrowRecords.DataSource = records.Select(record => new
            {
                BorrowRecordID = record.Id,  // Gizli ID ekleniyor
                BookID = record.BookID,
                UserID = record.UserID,
                UserName = record.User?.Name ?? "Bilinmiyor",
                BookName = record.Book?.Name ?? "Belirtilmemiş",
                BorrowDate = record.CreatedDate.ToString("dd-MM-yyyy"),
                DueDate = record.BorrowDate?.ToString("dd-MM-yyyy") ?? "Belirtilmemiş",
                ReturnDate = record.ReturnDate?.ToString("dd-MM-yyyy") ?? "Teslim Edilmedi",
                Status = record.Status
            }).ToList();

            // Gizli sütunlar
            dgvBorrowRecords.Columns["BorrowRecordID"].Visible = false;
            dgvBorrowRecords.Columns["BookID"].Visible = false;
            dgvBorrowRecords.Columns["UserID"].Visible = false;
        }
        private void dgvBorrowRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            // DataGridView'den seçili satırı al
            if (dgvBorrowRecords.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvBorrowRecords.SelectedRows[0].Index;

                // BorrowRecord ID'sini al
                var borrowRecordId = Guid.Parse(dgvBorrowRecords.Rows[selectedRowIndex].Cells["BorrowRecordID"].Value.ToString());

                var confirmResult = MessageBox.Show("Bu kaydı iade almak istediğinize emin misiniz?", "İade Onayı", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // BorrowRecord kaydını getir
                    var borrowRecord = _borrowRecordService.GetByID(borrowRecordId);

                    if (borrowRecord == null)
                    {
                        MessageBox.Show("Seçilen kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (borrowRecord.Status != BorrowStatus.ÖdünçVerildi)
                    {
                        MessageBox.Show("Seçilen kayıt zaten iade alınmış veya uygun değil.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // BorrowRecord'u güncelle
                    borrowRecord.Status = BorrowStatus.GeriAlındı;
                    borrowRecord.ReturnDate = DateTime.Now;

                    _borrowRecordService.Update(borrowRecord);

                    // Kullanıcıyı güncelle
                    var user = _userService.GetByID(borrowRecord.UserID);
                    if (user != null)
                    {
                        user.MaxBorrowLimit++;
                        _userService.Update(user);
                    }

                    // Kitabı güncelle
                    var book = _bookService.GetByID(borrowRecord.BookID);
                    if (book != null)
                    {
                        book.CopiesAvailable++;
                        book.AvailabilityStatus = book.CopiesAvailable > 0;

                        _bookService.Update(book);
                    }

                    MessageBox.Show("Kitap başarıyla iade alındı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tabloyu yenile
                    LoadAllRecordBooks();
                }
            }
            else
            {
                MessageBox.Show("Lütfen iade almak için bir kayıt seçin.");
            }

        }
        Book selectedBook;
        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedValue == null) return;

            // Seçilen kitabın ID'sini al
            var selectedBookId = Guid.Parse(cmbBooks.SelectedValue.ToString());

            // Kitap bilgilerini getir
            selectedBook = _bookService.GetByID(selectedBookId);

            if (selectedBook != null)
            {
                // UI Kontrollerine kitap bilgilerini yükle
                txtBookName.Text = selectedBook.Name;
                txtCopiesAvailable.Text = selectedBook.CopiesAvailable.ToString();
                pbBookCover.ImageLocation = selectedBook.CoverImageUrl; // Resim URL'sini kullan
            }
        }
        User selectedUser;
        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedValue == null) return;

            // Seçilen kitabın ID'sini al
            var selectedUserId = Guid.Parse(cmbUsers.SelectedValue.ToString());

            // Kitap bilgilerini getir
            selectedUser = _userService.GetByID(selectedUserId);

            if (selectedUser != null)
            {
                txtName.Text = selectedUser.Name;
                txtMaxBorrow.Text=selectedUser.MaxBorrowLimit.ToString();
            }
        }

        private void btnGiveBook_Click(object sender, EventArgs e)
        {
            if (grbKullanici.Visible) // Kullanıcı ve kitap seçim ekranı görünüyorsa
            {
                if (cmbUsers.SelectedValue == null || cmbBooks.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir kullanıcı ve kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var userId = Guid.Parse(cmbUsers.SelectedValue.ToString());
                var bookId = Guid.Parse(cmbBooks.SelectedValue.ToString());

                // Kullanıcı ve kitap bilgilerini getir
                var user = _userService.GetByID(userId);
                var book = _bookService.GetByID(bookId);

                // Kullanıcının MaxBorrowLimit kontrolü
                if (user.MaxBorrowLimit <= 0)
                {
                    MessageBox.Show("Kullanıcının ödünç alabileceği kitap sınırına ulaşıldı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kitabın kopya sayısını kontrol et
                if (book.CopiesAvailable <= 0)
                {
                    MessageBox.Show("Seçilen kitapta yeterli kopya yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kitabı tekrar ödünç verebilmek için ID'ye göre kontrol
                var existingRecord = _borrowRecordService.GetAll()
                    .FirstOrDefault(r => r.BookID == book.Id
                                     && r.UserID == user.Id
                                     && r.Status == BorrowStatus.ÖdünçVerildi);

                if (existingRecord != null)
                {
                    MessageBox.Show("Bu kitapın zaten kaydı var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Eğer geri alındıysa tekrar ödünç verilebilir
                var returnedRecord = _borrowRecordService.GetAll()
                    .FirstOrDefault(r => r.BookID == book.Id
                                     && r.UserID == user.Id
                                     && r.Status == BorrowStatus.GeriAlındı);

                if (returnedRecord != null)
                {
                    // Yeni bir ödünç kaydı oluştur
                    var borrowRecord = new BorrowRecord
                    {
                        BookID = bookId,
                        UserID = userId,
                        Status = BorrowStatus.ÖdünçVerildi,
                        BorrowDate = DateTime.Now,
                        ReturnDate = DateTime.Now.AddDays(14)
                    };

                    // Kullanıcının MaxBorrowLimit değerini azalt
                    user.MaxBorrowLimit--;
                    // Kitap kopya sayısını azalt
                    book.CopiesAvailable--;

                    // Veritabanı güncellemeleri
                    _borrowRecordService.Create(borrowRecord);
                    _userService.Update(user);
                    _bookService.Update(book);

                    MessageBox.Show("Kitap başarıyla tekrar ödünç verildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAllBorrowRecords();
                    LoadBooksToComboBox();
                }
            }
            else // Ayırtılmış bir kitabı ödünç vermek için DataGrid'den seçim yapılmışsa
            {
                if (dgvBorrowRecords.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Seçilen satırdan BorrowRecordID'yi al
                var selectedRowIndex = dgvBorrowRecords.SelectedRows[0].Index;
                var borrowRecordId = Guid.Parse(dgvBorrowRecords.Rows[selectedRowIndex].Cells["BorrowRecordID"].Value.ToString());

                // Kayıt getir
                var borrowRecord = _borrowRecordService.GetByID(borrowRecordId);

                if (borrowRecord == null || borrowRecord.Status != BorrowStatus.Ayırtıldı)
                {
                    MessageBox.Show("Seçilen kayıt ödünç verilemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kullanıcı ve Kitap bilgilerini getir
                var user = _userService.GetByID(borrowRecord.UserID);
                var book = _bookService.GetByID(borrowRecord.BookID);

                if (user == null || book == null)
                {
                    MessageBox.Show("Kullanıcı veya kitap bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kullanıcının kitap ödünç alma hakkını kontrol et
                if (user.MaxBorrowLimit <= 0)
                {
                    MessageBox.Show("Kullanıcının ödünç alabileceği kitap sınırına ulaşıldı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                

                // Kaydın durumunu güncelle
                borrowRecord.Status = BorrowStatus.ÖdünçVerildi;
                borrowRecord.BorrowDate = DateTime.Now;
                borrowRecord.ReturnDate = DateTime.Now.AddDays(14);

                // Kullanıcının kitap alma hakkını azalt
                user.MaxBorrowLimit--;


                // Değişiklikleri kaydet
                _borrowRecordService.Update(borrowRecord); // BorrowRecord güncelle
                _userService.Update(user); // Kullanıcı güncelle

                MessageBox.Show("Kitap başarıyla ödünç verildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbSearch.SelectedIndex = 0; // DataGrid'i yenile
            }
            
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSearch.SelectedIndex)
            {
                case 0:
                    LoadAllRecordBooks();     // Ayırtılan Kitaplar
                    break;
                case 1:
                    LoadReservedBooks();     // Ayırtılan Kitaplar
                    break;

                case 2:
                    LoadAllBorrowRecords();     // Ödünç Verilen Kitaplar
                    break;

                case 3:
                    LoadOverdueBooks();      // Gecikmiş Kitaplar
                    break;
            }
        }


        private void LoadAllRecordBooks()
        {
            var reservedRecords = _borrowRecordService.GetAll();
            BindToDataGrid(reservedRecords);
        }

        private void LoadReservedBooks()
        {
            var reservedRecords = _borrowRecordService.GetAll()
                .Where(r => r.Status == BorrowStatus.Ayırtıldı);
            BindToDataGrid(reservedRecords);
        }
        private void LoadAllBorrowRecords()
        {
            // Tüm borç kayıtlarını yükle
            var records = _borrowRecordService.GetAll()
                .Where(r => r.Status == BorrowStatus.ÖdünçVerildi);
            BindToDataGrid(records);
        }
        private void LoadOverdueBooks()
        {
            var overdueRecords = _borrowRecordService.GetAll()
                .Where(r => r.Status == BorrowStatus.ÖdünçVerildi &&
                            r.BorrowDate < DateTime.Now.AddDays(-14)); // Gecikmiş kitaplar
            BindToDataGrid(overdueRecords);
        }
        private void LoadUsersToComboBox()
        {
            // DataGridView'i temizle
            dgvBorrowRecords.DataSource = null;
            Guid currentAdminId = SessionManager.CurrentUser.Id;
            // Tüm kullanıcıları ComboBox'a yükle
            var allUsers = _userService.GetAll()
                .Where(u => u.Id != currentAdminId)
                .ToList();

            cmbUsers.DisplayMember = "Name";  // Kullanıcı adı görünecek
            cmbUsers.ValueMember = "Id";      // Kullanıcı ID'si tutulacak
            cmbUsers.DataSource = allUsers;

            cmbUsers.SelectedIndex = -1; // ComboBox'ta boş seçim
        }
        private void LoadBooksToComboBox()
        {
            var allBooks = _bookService.GetAll().Where(b => b.CopiesAvailable > 0).ToList();


            cmbBooks.DisplayMember = "Name";  // Kitap adı görünecek
            cmbBooks.ValueMember = "Id";      // Kitap ID'si tutulacak
            cmbBooks.DataSource = allBooks;
            cmbBooks.SelectedIndex = -1;
        }
        private void btnDegistirme_Click(object sender, EventArgs e)
        {
            // Eğer kullanıcı seçim grubu görünüyorsa, kayıt ekranına geri dön
            if (grbKullanici.Visible)
            {
                grbKullanici.Visible = false;  // Kullanıcı grubu gizlenir
                grbRecord.Visible = true;     // Kayıt grubu görünür hale gelir
                btnReturn.Visible = true;
                cmbSearch.SelectedIndex = 0;
                LoadAllRecordBooks();
            }
            else
            {
                LoadAllRecordBooks();
                // Olayları devre dışı bırak
                cmbBooks.SelectedIndexChanged -= cmbBooks_SelectedIndexChanged;
                cmbUsers.SelectedIndexChanged -= cmbUsers_SelectedIndexChanged;

                // Eğer kayıt grubu görünüyorsa, kullanıcı seçme ekranına geçiş yapılır
                grbKullanici.Visible = true;  // Kullanıcı grubu görünür hale gelir
                grbRecord.Visible = false;    // Kayıt grubu gizlenir
                grbKullanici.Location = grbRecord.Location;
                LoadUsersToComboBox();        // Kullanıcıları yükle
                LoadBooksToComboBox();        // Kitapları yükle
                btnReturn.Visible = false;
                // ComboBox'ların seçimini sıfırla
                cmbBooks.SelectedIndex = -1;
                cmbUsers.SelectedIndex = -1;

                // Olayları tekrar aktif hale getir
                cmbBooks.SelectedIndexChanged += cmbBooks_SelectedIndexChanged;
                cmbUsers.SelectedIndexChanged += cmbUsers_SelectedIndexChanged;
            }

        }


    }
}




