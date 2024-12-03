using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KYS.Entities.Models;

namespace KYS.Business.Validators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator() 
        {
            RuleFor(b => b.Name).NotEmpty()
               .WithMessage("Başlık Adı boş olamaz!");
            RuleFor(b => b.ISBN).NotEmpty()
               .WithMessage("ISBN numarası boş olamaz!");
            RuleFor(b => b.Publisher).NotEmpty()
               .WithMessage("Yayınci Adı boş olamaz!");
            RuleFor(b => b.PublishedYear).NotEmpty()
               .WithMessage("Yayın Yılı boş olamaz!");
            RuleFor(b => b.Description).NotEmpty()
               .WithMessage("Açıklama boş olamaz!");


        }
    }
}
