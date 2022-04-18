using Business.ValidationRules.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class StudentValidator:AbstractValidator<Student>,IValidate
    {
        public StudentValidator()
        {
            RuleFor(x => x.StudentName).NotEmpty().WithMessage("Lütfen isminizi boş geçmeyiniz!!");
            RuleFor(x => x.StudentName).MinimumLength(3).WithMessage("Lütfen geçerli bir isim giriniz!!").When(x => !string.IsNullOrEmpty(x.StudentName));
            RuleFor(x => x.StudentSurname).NotEmpty().WithMessage("Lütfen soyisminizi boş geçmeyiniz!!");
            RuleFor(x => x.StudentSurname).MinimumLength(2).WithMessage("Lütfen geçerli bir soyisim giriniz!!").When(x => !string.IsNullOrEmpty(x.StudentSurname));
            RuleFor(x => x.StudentMail).NotEmpty().WithMessage("Lütfen mail'inizi boş geçmeyiniz!!");
            RuleFor(x => x.StudentMail).EmailAddress().WithMessage("Lütfen mail adresinizi doğru formatta giriniz!").When(x => !string.IsNullOrEmpty(x.StudentMail));
            RuleFor(x => x.StudentPassword).NotEmpty().WithMessage("Lütfen şifrenizi boş geçmeyiniz!!");
            RuleFor(x => x.StudentNo).NotEmpty().WithMessage("Lütfen No kısmınızı boş geçmeyiniz!");
        }
    }
}
