using KYS.Entities.Abstractions;

namespace KYS.Entities.Models
{
    public class Comment : BaseEntity
    {
        public Guid BookID { get; set; } // Yorum yapılan kitabın ID'si (Foreign Key)
        public Book? Book { get; set; } // Kitap ile ilişki


        public Guid UserID { get; set; } // Yorumu yapan kullanıcının ID'si (Foreign Key)
        public User? User { get; set; } // Kullanıcı ile ilişki

        public string? Content { get; set; } // Yorum içeriği
        public int Rating { get; set; } // Yorumda verilen puan (1-5 arası gibi)

        // Tarih bilgileri zaten BaseEntity'den geliyor (CreatedDate, UpdatedDate).
    }
}
