using FluentValidation;
using KYS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYS.Business.Validators
{
    public class PublisherValidator: AbstractValidator<Publisher>
    {
        public PublisherValidator() 
        {
            RuleFor(a => a.Name).NotEmpty()
               .WithMessage("Yayıncı Adı boş olamaz!")
               .MinimumLength(3)
               .WithMessage("Yayıncı adı en az 3 karakter olmalıdır!");

            RuleFor(a => a.Country)
                .NotEmpty()
                .WithMessage("Ülke boş olamaz!");
        }
    }
}
