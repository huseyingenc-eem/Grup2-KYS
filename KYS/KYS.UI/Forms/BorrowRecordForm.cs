using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace KYS.UI.Forms
{
    public partial class BorrowRecordForm : Form
    {
        private readonly BorrowRecordService _borrowRecordService;
        private readonly BorrowRecordRepository _borrowRecordRepository;

        public Book? borrowBook;
        // burası bookdetailformda bulunan butondan gelecek. kitap hazır geliyor bunun içinde ona göre yap.
        public BorrowRecordForm()
        {
            InitializeComponent();
            var dBContext = new ApplicationDBContext();
            _borrowRecordRepository = new BorrowRecordRepository(dBContext);
            _borrowRecordService = new BorrowRecordService(_borrowRecordRepository);
        }

        private void BorrowRecordForm_Load(object sender, EventArgs e)
        {
            try
            {
                //using (var context = new LibraryContext())
                //{
                //    cmbBook.DataSource = context.Books.ToList();
                //    cmbBook.DisplayMember = "Name";
                //    cmbBook.ValueMember = "Id";

                //    cmbUser.DataSource = context.Users.ToList();
                //    cmbUser.DisplayMember = "Name";
                //    cmbUser.ValueMember = "Id";


                //    LoadBorrowRecords();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }

        }
        private void LoadBorrowRecords()
        {
            try
            {
                //using (var context = new LibraryContext())
                //{
                //    dgvRecords.DataSource = context.BorrowRecords
                //        .Include(br => br.Book)
                //        .Include(br => br.User)
                //        .Select(br => new
                //        {
                //            br.Id,
                //            BookName = br.Book.Name,
                //            UserName = br.User.Name,
                //            br.DueDate,
                //            br.Status
                //        })
                //        .ToList();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //using (var context = new LibraryContext())
                //{
                //    var newRecord = new BorrowRecord
                //    {
                //        BookID = (Guid)cmbBook.SelectedValue,
                //        UserID = (Guid)cmbUser.SelectedValue,
                //        DueDate = dtpDueDate.Value,
                //        Status = "Borrowed"
                //    }

                //context.BorrowRecords.Add(newRecord);
                //    context.SaveChanges();
                //    MessageBox.Show("Kayıt başarıyla eklendi.");
                //}

                LoadBorrowRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRecords.SelectedRows.Count > 0)
                {
                    //var selectedId = (int)dgvRecords.SelectedRows[0].Cells["Id"].Value;

                    //using (var context = new LibraryContext())
                    //{
                    //    var record = context.BorrowRecords.Find(selectedId);

                    //    if (record != null)
                    //    {
                    //        record.DueDate = dtpDueDate.Value;
                    //        record.Status = "Borrowed";
                    //        context.SaveChanges();
                    //        MessageBox.Show("Kayıt başarıyla güncellendi.");
                    //    }
                    //}

                    LoadBorrowRecords();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvRecords.SelectedRows.Count > 0)
                {
                    var selectedId = (int)dgvRecords.SelectedRows[0].Cells["Id"].Value;

                    //using (var context = new LibraryContext())
                    //{
                    //    var record = context.BorrowRecords.Find(selectedId);

                    //    if (record != null)
                    //    {
                    //        context.BorrowRecords.Remove(record);
                    //        context.SaveChanges();
                    //        MessageBox.Show("Kayıt başarıyla silindi.");
                    //    }
                    //}

                    LoadBorrowRecords();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }

        }

        private void btnMarkReturned_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRecords.SelectedRows.Count > 0)
                {
                    var selectedId = (int)dgvRecords.SelectedRows[0].Cells["Id"].Value;

                    //using (var context = new LibraryContext())
                    //{
                    //    var record = context.BorrowRecords.Find(selectedId);

                    //    if (record != null)
                    //    {
                    //        record.Status = "Returned";
                    //        context.SaveChanges();
                    //        MessageBox.Show("Kitap başarıyla iade edildi.");
                    //    }
                    //}

                    LoadBorrowRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}