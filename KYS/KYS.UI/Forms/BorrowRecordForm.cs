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

namespace KYS.UI.Forms
{
    public partial class BorrowRecordForm : Form
    {
        private readonly BorrowRecordService _borrowRecordService;
        private readonly BorrowRecordRepository _borrowRecordRepository;

        public Book? borrowBook;
        public User? currentUser;
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


            }


        private void btnSave_Click(object sender, EventArgs e)
        {


        }





        private void btnMarkReturned_Click(object sender, EventArgs e)
        {

          
        }
    }
}
