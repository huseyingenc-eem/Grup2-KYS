using KYS.Entities.Abstractions;

namespace KYS.Entities.Models
{
    public class BookType : BaseEntity
    {
        public string? Name { get; set; }           // Türün adı 
        public string? Description { get; set; }    // Tür açıklaması

        // Navigation Property
        public ICollection<Book>? Books { get; set; } // Bu türe ait kitaplar
    }

}