using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KYS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using KYS.DataAccess.Abstractions;

namespace KYS.UI.Forms
{
    public partial class BorrowRecordForm : Form
    {
        private readonly BorrowRecordService _borrowRecordService;
        private readonly BorrowRecordRepository _borrowRecordRepository;

        public Book? borrowBook;
        public User? currentUser;
        // burası bookdetailformda bulunan butondan gelecek. kitap hazır geliyor bunun içinde ona göre yap.
        private int _defaultBorrowDuration = 14;
        public BorrowRecordForm()
        {
            InitializeComponent();
            var dBContext = new ApplicationDBContext();
            _borrowRecordRepository = new BorrowRecordRepository(dBContext);
            _borrowRecordService = new BorrowRecordService(_borrowRecordRepository);
        }

        private void BorrowRecordForm_Load(object sender, EventArgs e)
        {

            if (borrowBook != null)
            {
                txtBookName.Text = borrowBook.Name;
                txtAuthorName.Text = borrowBook.AuthorName;
                pictureBoxPhoto.ImageLocation = borrowBook.ImagePath;
            }


            if (currentUser != null)
            {
                txtUserName.Text = currentUser.Name;

            }


            dtpBorrowDate.Value = DateTime.Now;
            dtpReturnDate.Value = dtpBorrowDate.Value.AddDays(_defaultBorrowDuration);

            lblMessage.Text = $"{_defaultBorrowDuration} gün içinde teslim edilmelidir.";

        }
        private void dtpBorrowDate_ValueChanged(object sender, EventArgs e)
        {

            dtpReturnDate.Value = dtpBorrowDate.Value.AddDays(_defaultBorrowDuration);
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (borrowBook == null || currentUser == null)
            {
                MessageBox.Show("Kitap veya kullanıcı bilgileri eksik!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            var borrowRecord = new BorrowRecord
            {
                BookID = borrowBook.Id,
                UserID = currentUser.Id,
                BorrowDate = dtpBorrowDate.Value,
                ReturnDate = dtpReturnDate.Value
            };

            
            try
            {
                
                string query = "INSERT INTO BorrowRecord (BookId, UserId, BorrowDate, ReturnDate) " +
                               "VALUES (@BookId, @UserId, @BorrowDate, @ReturnDate)";
                           
                _borrowRecordRepository.Create(query, borrowRecord);

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

        
