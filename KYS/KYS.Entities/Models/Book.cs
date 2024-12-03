using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KYS.Entities.Abstractions;

namespace KYS.Entities.Models
{
    public class Book : BaseEntity
    {
        public string? Name { get; set; }                  // Kitap Başlığı
        public string? ISBN { get; set; }                   // ISBN Numarası
        public int PublishedYear { get; set; }              // Yayınlanma Yılı
        public int Pages { get; set; }                      // Sayfa Sayısı
        public int CopiesAvailable { get; set; }            // Mevcut Kopya Sayısı
        public string? Description { get; set; }            // Kitap Açıklaması
        public string? Language { get; set; }               // Kitabın Dili
        public string? CoverImageUrl { get; set; }          // Kapak Resmi URL
        public bool AvailabilityStatus { get; set; }        //True ise var False ise yok.
        // Navigation Property : Authoer
        public Guid AuthorID { get; set; }                  // Yazar ID'si (Yabancı Anahtar)
        public string? AuthorName => Author?.Name;          //Yazar Adı
        public Author? Author { get; set; }                 // Yazar ile ilişki

        // Navigation Property : Type
        public Guid BookTypeID { get; set; }                // Tür ID'si (Yabancı Anahtar)
        public string? BookTypeName => BookType?.Name;      //Tür Name
        public BookType? BookType { get; set; }             // Tür ile ilişki

        // Navigation Property : Publisher
        public Guid PublicherID { get; set; }               // Yayıncı ID'si
        public string? PublicherName => Publisher?.Name;    // Yayıncı Adı
        public Publisher? Publisher { get; set; }           // Yayıncı ile ilişki

        // Navigation Property : BorrowRecord
        public ICollection<BorrowRecord>? BorrowRecord { get; set; } // Kitabın ödünç alma kayıtları

        // Navigation Property : Comment
        public ICollection<Comment>? Comments { get; set; } // Kitaba ait yorumlar

    }
}