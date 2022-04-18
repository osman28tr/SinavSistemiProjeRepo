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
    public class WrongAnswerValidator:AbstractValidator<WrongAnswer>,IValidate
    {
        public WrongAnswerValidator()
        {
            RuleFor(x => x.WrongAnswerName).NotEmpty().WithMessage("Lütfen yanlış cevap olan seçeneklerinizi boş geçmeyiniz");
        }
    }
}
