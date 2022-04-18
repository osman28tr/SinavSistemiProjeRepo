using Business.ValidationRules.Abstract;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AdminValidator:AbstractValidator<Admin>,IValidate
    {
        public AdminValidator()
        {
            RuleFor(x => x.AdminName).NotEmpty().WithMessage("Lütfen isminizi boş geçmeyiniz!!");
            RuleFor(x => x.AdminName).MinimumLength(3).WithMessage("Lütfen geçerli bir isim giriniz!!").When(x => !string.IsNullOrEmpty(x.AdminName));
            RuleFor(x => x.AdminSurname).NotEmpty().WithMessage("Lütfen soyisminizi boş geçmeyiniz!!");
            RuleFor(x => x.AdminSurname).MinimumLength(2).WithMessage("Lütfen geçerli bir soyisim giriniz!!").When(x => !string.IsNullOrEmpty(x.AdminSurname));
            RuleFor(x => x.AdminMail).NotEmpty().WithMessage("Lütfen mail'inizi boş geçmeyiniz!!");
            RuleFor(x => x.AdminMail).EmailAddress().WithMessage("Lütfen mail adresinizi doğru formatta giriniz!").When(x => !string.IsNullOrEmpty(x.AdminMail));
            RuleFor(x => x.AdminPassword).NotEmpty().WithMessage("Lütfen şifrenizi boş geçmeyiniz!!");
        }
    }
}
