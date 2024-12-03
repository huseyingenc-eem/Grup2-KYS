using KYS.Entities.Abstractions;

namespace KYS.Entities.Models
{
    public class Author : BaseEntity
    {
        public string? Name { get; set; }           //Adı
        public string? Surname { get; set; }        //Soyadı
        public string? FullName => $"{Name} {Surname}";
        public DateTime? BirthDate { get; set; }    // Doğum Tarihi
        public DateTime? DeathDate { get; set; }    //Ölüm Tarihi
        public string? Biography { get; set; }       //Biyografi
        public string? Country { get; set; }        //Ülke
        public string? PhotoUrl { get; set; }       // Yazarın Fotoğrafı URL

        //Navigation Property
        public ICollection<Book>? Products { get; set; }
    }

}
