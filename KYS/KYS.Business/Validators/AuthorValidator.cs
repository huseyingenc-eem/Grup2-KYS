using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KYS.Entities.Models;

namespace KYS.Business.Validators
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator() 
        {
            RuleFor(a => a.Name).NotEmpty()
               .WithMessage("Yazar Adı boş olamaz!");
            RuleFor(a => a.Surname).NotEmpty()
               .WithMessage("Yazar Soyadı boş olamaz!");
            RuleFor(a => a.Biography).NotEmpty()
               .WithMessage("Biogarfi boş olamaz!");
        }
    }
}
