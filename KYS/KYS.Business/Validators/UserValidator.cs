using FluentValidation;
using KYS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYS.Business.Validators
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator() 
        {
            // Username Validation
            RuleFor(user => user.Username)
                .NotEmpty()
                .WithMessage("Kullanıcı adı boş olamaz.")
                .MinimumLength(3)
                .WithMessage("Kullanıcı adı en az 3 karakter olmalıdır.")
                .MaximumLength(20)
                .WithMessage("Kullanıcı adı en fazla 20 karakter olabilir.");

            // Name Validation
            RuleFor(user => user.Name)
                .NotEmpty()
                .WithMessage("Ad boş olamaz.");

            // Surname Validation
            RuleFor(user => user.Surname)
                .NotEmpty()
                .WithMessage("Soyad boş olamaz.");

            // Password Validation
            RuleFor(user => user.Password)
                .NotEmpty()
                .WithMessage("Şifre boş olamaz.")
                .MinimumLength(6)
                .WithMessage("Şifre en az 6 karakter olmalıdır.");

            // Email Validation
            RuleFor(user => user.Email)
                .NotEmpty()
                .WithMessage("E-posta adresi boş olamaz.");
                //.EmailAddress()
                //.WithMessage("Geçerli bir e-posta adresi girin.");
                

        }
    }
}
