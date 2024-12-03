using KYS.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYS.Entities.Models
{
    public class Publisher:BaseEntity
    {
        
            public string? Name { get; set; }            // Yayıncı adı
            public string? Country { get; set; }         // Yayıncının ülkesi

            // Navigation Property
            public ICollection<Book>? Books { get; set; } // Yayıncının yayımladığı kitaplar
    }
}
