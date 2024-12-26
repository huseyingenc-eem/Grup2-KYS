using FluentValidation;
using KYS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYS.Business.Validators
{
    public class DuyurularValidator: AbstractValidator<Duyurular>
    {
        public DuyurularValidator() 
        {
            RuleFor(b => b.Baslik)
               .NotEmpty()
               .WithMessage("Başlık adı boş olamaz!")
               .MinimumLength(3)
               .WithMessage("Başlık en az 3 karakter olmalıdır!");

            RuleFor(b => b.Icerik)
              .NotEmpty()
              .WithMessage("İçerik boş olamaz!")
              .MinimumLength(3)
              .WithMessage("İçerik en az 3 karakter olmalıdır!");
        }
    }
}
