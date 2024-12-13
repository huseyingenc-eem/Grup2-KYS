using KYS.Entities.Abstractions;

namespace KYS.Entities.Models
{
    public class BorrowRecord : BaseEntity
    {
        public BorrowRecord()
        {
            BorrowDate = CreatedDate.AddDays(14); // 2 hafta sonrasını otomatik olarak ayarla
        }

        public Guid BookID { get; set; }  // Ödünç alınan kitabın ID'si (Yabancı Anahtar)
        public Book? Book { get; set; }    // Kitap ile ilişki
        public string? BookName => Book?.Name;


        public Guid UserID { get; set; }  // Kitabı ödünç alan kullanıcının ID'si (Yabancı Anahtar)
        public User? User { get; set; }   // Kullanıcı ile ilişki


        public DateTime? BorrowDate { get; set; } // İade edilmesi gereken son tarih
        public DateTime? ReturnDate { get; set; } // Gerçek iade tarihi (opsiyonel)

        public string? Status { get; set; } = "Borrowed"; // Ödünç alma durumu (ör. "Borrowed", "Returned", "Overdue")
        
    }

}