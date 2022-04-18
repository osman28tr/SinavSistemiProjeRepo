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
    public class TeacherValidator : AbstractValidator<Teacher>,IValidate
    {
        public TeacherValidator()
        {
            RuleFor(x => x.TeacherName).NotEmpty().WithMessage("Lütfen isminizi boş geçmeyiniz!!");
            RuleFor(x => x.TeacherName).MinimumLength(3).WithMessage("Lütfen geçerli bir isim giriniz!!").When(x => !string.IsNullOrEmpty(x.TeacherName));
            RuleFor(x => x.TeacherSurname).NotEmpty().WithMessage("Lütfen soyisminizi boş geçmeyiniz!!");
            RuleFor(x => x.TeacherSurname).MinimumLength(2).WithMessage("Lütfen geçerli bir isim giriniz!!").When(x => !string.IsNullOrEmpty(x.TeacherSurname));
            RuleFor(x => x.TeacherMail).NotEmpty().WithMessage("Lütfen mail'inizi boş geçmeyiniz!!");
            RuleFor(x => x.TeacherMail).EmailAddress().WithMessage("Lütfen mail adresinizi doğru formatta giriniz!").When(x => !string.IsNullOrEmpty(x.TeacherMail));
            RuleFor(x => x.TeacherPassword).NotEmpty().WithMessage("Lütfen şifrenizi boş geçmeyiniz!!");
            RuleFor(x => x.TeacherTel).NotEmpty().WithMessage("lütfen telefonunuzu boş geçmeyiniz!");
            RuleFor(x => x.TeacherTel).MaximumLength(11).WithMessage("lütfen telefonunuzu doğru uzunlukta giriniz!").When(x => !string.IsNullOrEmpty(x.TeacherTel));
        }
    }
}
