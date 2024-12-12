using FluentValidation;
using KYS.Entities.Models;

namespace KYS.Business.Validators
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator() 
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .WithMessage("Yazar Adı boş olamaz!")
                .MinimumLength(2)
                .WithMessage("Yazar Adı en az 2 karakter olmalıdır!");

            RuleFor(a => a.Surname)
                .NotEmpty()
                .WithMessage("Yazar Soyadı boş olamaz!")
                .MinimumLength(2)
                .WithMessage("Yazar Soyadı en az 2 karakter olmalıdır!");

            RuleFor(a => a.BirthDate)
                .LessThan(DateTime.Now)
                .WithMessage("Doğum tarihi gelecekte olamaz!");

            RuleFor(a => a.DeathDate)
                .GreaterThanOrEqualTo(a => a.BirthDate).When(a => a.BirthDate.HasValue && a.DeathDate.HasValue)
                .WithMessage("Ölüm tarihi, doğum tarihinden önce olamaz!");

            RuleFor(a => a.Biography)
                .NotEmpty()
                .WithMessage("Biyografi boş olamaz!");

            RuleFor(a => a.Country)
                .NotEmpty()
                .WithMessage("Ülke boş olamaz!");

            RuleFor(a => a.PhotoUrl)
                .NotEmpty()
                .WithMessage("Fotoğraf URL'si boş olamaz!");
        }
    }
}
