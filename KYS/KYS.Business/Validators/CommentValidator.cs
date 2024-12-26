using FluentValidation;
using KYS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYS.Business.Validators
{
    public class CommentValidator: AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(b => b.Content)
                .NotEmpty()
                .WithMessage("Yorum boş olamaz!")
                .MinimumLength(5)
                .WithMessage("Yorum az 5 karakter olmalıdır!");
        }
    }
}
