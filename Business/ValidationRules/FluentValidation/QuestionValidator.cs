using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class QuestionValidator:AbstractValidator<Question>
    {
        public QuestionValidator()
        {
            RuleFor(x => x.QuestionName).NotEmpty().WithMessage("Lütfen soruyu boş geçmeyiniz!");
            RuleFor(x => x.SubjectId).NotEmpty().WithMessage("Lütfen bir konu seçiniz!");
            RuleFor(x => x.PicturePath).NotEmpty().WithMessage("Lütfen bir resim seçiniz!");
        }
    }
}
