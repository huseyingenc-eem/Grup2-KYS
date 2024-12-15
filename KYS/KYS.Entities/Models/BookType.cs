using KYS.Entities.Abstractions;

namespace KYS.Entities.Models
{
    public class BookType : BaseEntity
    {
        private static readonly Random _random = new Random();

        private string? _name;
        public string? Name
        {
            get => _name;
            set
            {
                _name = value;
                GenerateShortCode(); // Name set edilince ShortCode otomatik oluşur.
            }
        }
        public string? Description { get; set; }    // Tür açıklaması
        public string? ShortCode { get; set; }      // Tür kısaltması (örn: "BK(benzersiz 3 haneli sayı)" -> Bilim Kurgu) örnek:Bk323 gibi
        // Navigation Property
        public ICollection<Book>? Books { get; set; } // Bu türe ait kitaplar

        private void GenerateShortCode()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                // Adın baş harflerini al
                string initials = string.Concat(Name.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(word => word[0]))
                                                    .ToUpper();

                // 3 haneli rastgele sayı üret
                string randomNumber = _random.Next(100, 1000).ToString();

                // ShortCode'u oluştur
                ShortCode = $"{initials}{randomNumber}";
            }
            else
            {
                ShortCode = null; // Eğer Name boşsa ShortCode null olur
            }
        }
    }

}