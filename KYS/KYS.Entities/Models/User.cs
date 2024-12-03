using KYS.Entities.Abstractions;

namespace KYS.Entities.Models
{
    public class User : BaseEntity
    {
        public string? Username { get; set; }       // Kullanıcı adı

        public string? Name { get; set; }           //Adı
        public string? Surname { get; set; }        //Soyad
        public string? FullName => $"{Name} {Surname}";

        public string? Password { get; set; }       // Şifre (hashlenmiş)
        public string? Email { get; set; }          // E-posta adresi

        public int MaxBorrowLimit { get; set; } = 5; // Varsayılan limit

        public bool IsAdmin { get; set; } = false; // Yönetici olup olmadığını belirtir.

        public ICollection<Comment>? Comments { get; set; } // Kullanıcının yaptığı yorumlar
    }

}