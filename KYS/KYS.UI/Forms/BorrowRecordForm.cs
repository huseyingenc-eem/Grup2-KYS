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

namespace KYS.UI.Forms
{
    public partial class BorrowRecordForm : Form
    {
        public Book? borrowBook;
        // burası bookdetailformda bulunan butondan gelecek. kitap hazır geliyor bunun içinde ona göre yap.
        public BorrowRecordForm()
        {
            InitializeComponent();
        }

        private void BorrowRecordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
