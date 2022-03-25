using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CorrectAnswerValidator:AbstractValidator<CorrectAnswer>
    {
        public CorrectAnswerValidator()
        {
            RuleFor(x => x.CorrectAnswerName).NotEmpty().WithMessage("Lütfen bir doğru cevap seçiniz");
        }
    }
}
