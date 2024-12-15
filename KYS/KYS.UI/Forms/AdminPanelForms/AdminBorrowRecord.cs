using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
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

        public AdminBorrowRecord()
        {
            InitializeComponent();
            var dBContext = new ApplicationDBContext();
            _borrowRecordService = new BorrowRecordService(new BorrowRecordRepository(dBContext));
            var borrowRepository = new BorrowRecordRepository(dBContext);
        }

        private void LoadAllBorrowRecords()
        {
            // Tüm borç kayıtlarını yükle
            var records = _borrowRecordService.GetAll();
            BindToDataGrid(records);
        }
        private void BindToDataGrid(IEnumerable<BorrowRecord> records)
        {
            dgvBorrowRecords.DataSource = records.Select(record => new
            {
                Id = record.Id,
                UserName = record.User?.Name ?? "Bilinmiyor",
                BookName = record.Book?.Name ?? "Belirtilmemiş",
                BorrowDate = record.CreatedDate.ToString("dd-MM-yyyy"),
                DueDate = record.BorrowDate?.ToString("dd-MM-yyyy") ?? "Belirtilmemiş",
                ReturnDate = record.ReturnDate?.ToString("dd-MM-yyyy") ?? "Teslim Edilmedi",
                Status = record.Status
            }).ToList();
            dgvBorrowRecords.Columns["Id"].Visible = false;
        }
        private void dgvBorrowRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void AdminBorrowRecord_Load(object sender, EventArgs e)
        {
            LoadAllBorrowRecords();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // DataGridView'den seçili satırı al
            if (dgvBorrowRecords.SelectedRows.Count > 0)
            {
                // Seçili satırdaki BorrowRecord ID'sini al
                int selectedRowIndex = dgvBorrowRecords.SelectedRows[0].Index;
                Guid recordId = Guid.Parse(dgvBorrowRecords.Rows[selectedRowIndex].Cells["Id"].Value.ToString());

                // Silme işlemi
                var confirmResult = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // BorrowRecordService üzerinden sil
                    _borrowRecordService.Delete(recordId);

                    // Güncellenmiş kayıtları yükle
                    LoadAllBorrowRecords();

                    MessageBox.Show("Kayıt başarıyla silindi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir kayıt seçin.");
            }

        }
    }
}




