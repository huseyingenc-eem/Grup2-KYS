using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KYS.Business.Services;
using KYS.Entities.Models;

namespace KYS.UI.Forms.UserPanelForms
{
    public partial class MyBorrowRecord : Form
    {
        private readonly BorrowRecordService _borrowRecordService;
        private Guid _currentUserId;
        public MyBorrowRecord(BorrowRecordService borrowRecordService, Guid currentUserId)
        {
            InitializeComponent();
            _borrowRecordService = borrowRecordService;
            _currentUserId = currentUserId;


        }

        private void LoadBorrowRecords()
        {
            var records = _borrowRecordService.GetBorrowRecordsByUser(_currentUserId);
            BindToDataGrid(records);
        }

        private void BindToDataGrid(IEnumerable<BorrowRecord> records)
        {
            dgvBorrowRecords.DataSource = records.Select(r => new
            {
                BookName = r.Book?.Name,
                BorrowDate = r.DueDate.ToString("yyyy-MM-dd"),
                ReturnDate = r.ReturnDate?.ToString("yyyy-MM-dd") ?? "Not Returned",
                Status = r.Status
            }).ToList();
        }
        private void MyBorrowRecord_Load(object sender, EventArgs e)
        {
            LoadBorrowRecords();
        }



        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            var records = _borrowRecordService.GetBorrowRecordsByUser(_currentUserId);

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

