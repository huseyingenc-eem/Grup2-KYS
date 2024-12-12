using FluentValidation;
using KYS.Entities.Models;

namespace KYS.Business.Validators
{
    public class BookTypeValidator : AbstractValidator<BookType>
    {
        public BookTypeValidator() 
        {
            RuleFor(a => a.Name).NotEmpty()
               .WithMessage("Tür Adı boş olamaz!");
            RuleFor(a => a.Description).NotEmpty()
              .WithMessage("Açıklama boş olamaz!");
        }
    }
}
