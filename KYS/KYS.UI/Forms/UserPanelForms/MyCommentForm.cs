using KYS.Business.Services;
using KYS.DataAccess.Context;
using KYS.DataAccess.Repositories;
using KYS.Entities.Models;
using KYS.UI.Helpers;
using System.Data;
using static KYS.UI.Forms.UserPanelForms.BookDetailForm;

namespace KYS.UI.Forms.UserPanelForms
{
    public partial class MyCommentForm : Form
    {
        private readonly CommentService _commentRecordService;
        private readonly BookService _bookService;

        private User currentuser = SessionManager.CurrentUser;

        public MyCommentForm()
        {
            InitializeComponent();
            var dBContext = new ApplicationDBContext();
            _commentRecordService = new CommentService(new CommentRepository(dBContext));
            _bookService = new BookService(new BookRepository(dBContext));
        }

        private void MyCommentForm_Load(object sender, EventArgs e)
        {
            LoadCommentRecords();

        }

        private void LoadCommentRecords()
        {
            var comments = _commentRecordService.GetAll()
               .Where(record => record.UserID == currentuser.Id);
            BindToDataGrid(comments);
        }

        private void BindToDataGrid(IEnumerable<Comment> comments)
        {
            dgvCommentRecords.DataSource = comments.Select(comment => new
            {
                BookID = comment.Book?.Id,
                BookName = comment.Book?.Name ?? "Belirtilmemiş",
                Content = comment.Content,
                CreatedDate = comment.CreatedDate.ToString("dd-MM-yyyy")
            }).ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            var records = _commentRecordService.GetAll().Where(record => record.UserID == currentuser.Id); // Kullanıcıya göre filtrele

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

        private void dgvCommentRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
