using KYS.Entities.Abstractions;

namespace KYS.Entities.Models
{
    public class Duyurular : BaseEntity
    {
        public string? Baslik { get; set; }          // Duyuru başlığı
        public string? Icerik { get; set; }          // Duyuru içeriği
        public DateTime DuyuruTarihi { get; set; }  // Yayınlanma tarihi
    }

}
