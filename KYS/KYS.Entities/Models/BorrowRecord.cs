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

        public BorrowStatus Status { get; set; } = BorrowStatus.Ayırtıldı; // Ödünç alma durumu (ör. "Borrowed", "Returned", "Overdue")
        
    }

}
public enum BorrowStatus
{
    Ayırtıldı = 1,    // Kitap ayırtıldı
    ÖdünçVerildi = 2, // Kitap ödünç verildi
    TeslimEdildi = 3, // Kitap teslim edildi
    İptalEdildi = 4   // Ayırtma iptal edildi
}