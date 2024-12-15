using KYS.Entities.Abstractions;

namespace KYS.Entities.Models
{
    public class Author : BaseEntity
    {
        private string? _name;
        private string? _surname;

        public string? Name
        {
            get => _name;
            set
            {
                _name = value;
                GenerateShortCode();
            }
        }

        public string? Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                GenerateShortCode();
            }
        }
        public string? FullName => $"{Name} {Surname}";
        public string? ShortCode { get; set; }      // Yazar kısaltması (örn: "A" -> Atay)
        public DateTime? BirthDate { get; set; }    // Doğum Tarihi
        public DateTime? DeathDate { get; set; }    //Ölüm Tarihi
        public string? Biography { get; set; }       //Biyografi
        public string? Country { get; set; }        //Ülke
        public string? PhotoUrl { get; set; }       // Yazarın Fotoğrafı URL

        //Navigation Property
        public ICollection<Book>? Products { get; set; }

        private void GenerateShortCode()
        {
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Surname))
            {
                // İsmin ve soyismin ilk harflerini büyük harf olarak al
                string nameInitial = Name.Substring(0, 1).ToUpper();
                string surnameInitial = Surname.Substring(0, 1).ToUpper();

                ShortCode = $"{nameInitial}{surnameInitial}";
            }
            else
            {
                ShortCode = null; // Eğer Name veya Surname boşsa ShortCode null olur
            }
        }
    }

}
