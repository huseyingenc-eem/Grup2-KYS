using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using KYS.UI.Helpers;
using System.Data;

namespace KYS.UI.Forms.UserPanelForms
{
    public partial class MyBorrowRecord : Form
    {
        private readonly BorrowRecordService _borrowRecordService;

        private User currentuser = SessionManager.CurrentUser;

        public MyBorrowRecord()
        {
            InitializeComponent();
            var dBContext = new ApplicationDBContext();
            _borrowRecordService = new BorrowRecordService(new BorrowRecordRepository(dBContext));
        }
        private void MyBorrowRecord_Load(object sender, EventArgs e)
        {
            LoadBorrowRecords();
        }
        private void LoadBorrowRecords()
        {

            var records = _borrowRecordService.GetAll()
                .Where(record => record.UserID == currentuser.Id);
            BindToDataGrid(records);
        }

        private void BindToDataGrid(IEnumerable<BorrowRecord> records)
        {
            dgvBorrowRecords.DataSource = records.Select(records => new
            {
                BookName = records.Book?.Name ?? "Belirtilmemiş",
                BorrowDate = records.CreatedDate.ToString("dd-MM-yyyy"),
                DueDate = records.BorrowDate?.ToString("dd-MM-yyyy") ?? "Belirtilmemiş",
                ReturnDate = records.ReturnDate?.ToString("dd-MM-yyyy") ?? "Teslim Edilmedi",
                Status = records.Status
            }).ToList();

            // Sütun başlıklarını özelleştir
            dgvBorrowRecords.Columns["BookName"].HeaderText = "Kitap Adı";
            dgvBorrowRecords.Columns["BorrowDate"].HeaderText = "Ödünç Alma Tarihi";
            dgvBorrowRecords.Columns["DueDate"].HeaderText = "Son Teslim Tarihi";
            dgvBorrowRecords.Columns["ReturnDate"].HeaderText = "İade Tarihi";
            dgvBorrowRecords.Columns["Status"].HeaderText = "Durum";
        }
        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            var records = _borrowRecordService.GetAll().Where(record => record.UserID == currentuser.Id); // Kullanıcıya göre filtrele

            // Eğer arama metni 3 karakterden azsa tüm kayıtları göster.
            if (string.IsNullOrEmpty(searchText) || searchText.Length < 3)
            {
                BindToDataGrid(records);
                return;
            }

            // Eğer arama metni 3 veya daha fazla karakterse, filtrelenmiş kayıtları göster.
            var filteredRecords = records.Where(r =>
                r.Book?.Name != null &&
                r.Book.Name.StartsWith(searchText, StringComparison.OrdinalIgnoreCase));

            BindToDataGrid(filteredRecords);
        }
    }
}

