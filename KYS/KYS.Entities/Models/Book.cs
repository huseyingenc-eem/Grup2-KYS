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
        private int _copiesAvailable;

        public string? Name { get; set; }                  // Kitap Başlığı
        public string? ISBN { get; set; }                   // ISBN Numarası
        public int PublishedYear { get; set; }              // Yayınlanma Yılı
        public int Pages { get; set; }                      // Sayfa Sayısı
        public int CopiesAvailable                          // Mevcut Kopya Sayısı
        {
            get => _copiesAvailable;
            set
            {
                _copiesAvailable = value;
                AvailabilityStatus = _copiesAvailable > 0; // Kopya sayısına göre durumu belirle
            }
        }            
        public string? Description { get; set; }            // Kitap Açıklaması
        public string? Language { get; set; }               // Kitabın Dili
        public string? CoverImageUrl { get; set; }          // Kapak Resmi URL
        public bool AvailabilityStatus { get; private set; }        //True ise var False ise yok.

        // Navigation Property : Authoer
        public Guid AuthorID { get; set; }                      // Yazar ID'si (Yabancı Anahtar)
        public Author? Author { get; set; }             // Yazar ile ilişki

        // Navigation Property : Type
        public Guid BookTypeID { get; set; }                    // Tür ID'si (Yabancı Anahtar)
        public  BookType? BookType { get; set; }         // Tür ile ilişki

        // Navigation Property : Publisher
        public Guid PublisherID { get; set; }                   // Yayıncı ID'si
        public  Publisher? Publisher { get; set; }       // Yayıncı ile ilişki

        // Navigation Property : BorrowRecord
        public ICollection<BorrowRecord>? BorrowRecord { get; set; } // Kitabın ödünç alma kayıtları

        // Navigation Property : Comment
        public ICollection<Comment>? Comments { get; set; } // Kitaba ait yorumlar

        

    }

}