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
        public readonly string ImagePath;

        private int _copiesAvailable;

        public string? Name { get; set; }                  // Kitap Başlığı

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
        public bool AvailabilityStatus { get; set; }        //True ise var False ise yok.

        private string? _shelfLocation; // ShelfLocation'ı tutacak alan
        private IEnumerable<Book> _existingBooks; // Dışarıdan mevcut kitap listesi 
        public string? ShelfLocation
        {
            get
            {
                if (_shelfLocation == null)
                {
                    _shelfLocation = GenerateShelfLocation(_existingBooks); // Hesaplama yapılır
                }
                return _shelfLocation;
            }
            private set
            {
                _shelfLocation = value; // Sadece içeriden set edilir
            }
        }
        public void SetExistingBooks(IEnumerable<Book> existingBooks)
        {
            _existingBooks = existingBooks; // Mevcut kitaplar atanır
        }
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

        private string GenerateShelfLocation(IEnumerable<Book> existingBooks)
        {
            if (BookType == null || Author == null || string.IsNullOrEmpty(Name))
                throw new InvalidOperationException("BookType, Author ve Name alanları dolu olmalıdır.");

            // Kitap adının baş harfini al
            char bookInitial = char.ToUpper(Name[0]);

            // Bölge kodu (BookType ShortCode + kitap baş harfi)
            string baseCode = $"{BookType.ShortCode}-{bookInitial}";

            // Aynı tür, aynı baş harf ve yazar koduna sahip kitapları kontrol et
            var booksWithSameBaseCode = existingBooks
                .Where(b => b.ShelfLocation != null
                            && b.ShelfLocation.StartsWith(baseCode)
                            && b.ShelfLocation.EndsWith(Author.ShortCode))
                .ToList();

            // En yüksek pozisyon numarasını bul
            int maxPosition = booksWithSameBaseCode
                .Select(b =>
                {
                    var parts = b.ShelfLocation.Split('-');
                    return parts.Length >= 3 && int.TryParse(parts[2], out int pos) ? pos : 0;
                })
                .DefaultIfEmpty(0)
                .Max();

            // Yeni pozisyonu belirle
            int nextPosition = maxPosition + 1;

            // Raf numarasını hesapla
            int shelfNumber = (nextPosition / 20) + 1;
            int positionInShelf = (nextPosition % 20 == 0) ? 20 : nextPosition % 20;

            // Yeni kitap yeri kodu oluştur
            return $"{baseCode}{shelfNumber:D2}-{positionInShelf:D3}-{Author.ShortCode}";
        }

    }

}