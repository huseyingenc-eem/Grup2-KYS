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
            RuleFor(b => b.Name)
                .NotEmpty()
                .WithMessage("Kitap adı boş olamaz!")
                .MinimumLength(3)
                .WithMessage("Kitap adı en az 3 karakter olmalıdır!");

            

            RuleFor(b => b.Publisher)
                .NotNull()
                .WithMessage("Yayıncı seçimi yapılmalıdır!");

            RuleFor(b => b.PublishedYear)
                .GreaterThan(0).WithMessage("Yayınlanma yılı sıfırdan büyük olmalıdır!")
                .LessThanOrEqualTo(DateTime.Now.Year)
                .WithMessage($"Yayınlanma yılı {DateTime.Now.Year} yılını aşamaz!");

            RuleFor(b => b.Pages)
                .GreaterThan(0)
                .WithMessage("Sayfa sayısı sıfırdan büyük olmalıdır!");

            RuleFor(b => b.CopiesAvailable)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Mevcut kopya sayısı sıfırdan küçük olamaz!");

            RuleFor(b => b.Description)
                .NotEmpty()
                .WithMessage("Açıklama boş olamaz!");

            // Kapak resmi URL kontrolü
            RuleFor(b => b.CoverImageUrl)
                .NotEmpty().WithMessage("Kapak resmi URL boş olamaz!");

            // Dil boş olamaz
            RuleFor(b => b.Language)
                .NotEmpty()
                .WithMessage("Kitabın dili boş olamaz!");
        }


    }
    
}
