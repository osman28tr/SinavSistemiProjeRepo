using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WrongAnswerManager : IWrongAnswerService
    {
        IWrongAnswerDal _wrongAnswerDal;
        private static WrongAnswerValidator wrongAnswerValidator = new WrongAnswerValidator();
        List<string> validations = new List<string>();
        public WrongAnswerManager(IWrongAnswerDal wrongAnswerDal)
        {
            _wrongAnswerDal = wrongAnswerDal;
        }
        public List<string> Add(WrongAnswer wrongAnswer)
        {
            IList<ValidationFailure> failures = Dogrula(wrongAnswer);
            if (failures != null)
            {
                foreach (var failure in failures)
                {
                    validations.Add(failure.ErrorMessage);
                }
                return validations;
            }
            else
            {
                _wrongAnswerDal.Add(wrongAnswer);
                return null;
            }
        }
        public IList<ValidationFailure> Dogrula(WrongAnswer wrongAnswer)
        {
            var result = wrongAnswerValidator.Validate(wrongAnswer);
            IList<ValidationFailure> failures = result.Errors;
            if (!result.IsValid)
            {
                return failures;
            }
            else
            {
                return null;
            }
        }

        public void Delete(WrongAnswer wrongAnswer)
        {
            _wrongAnswerDal.Delete(wrongAnswer);
        }

        public WrongAnswer Get()
        {
            return _wrongAnswerDal.Get();
        }

        public List<WrongAnswer> GetAll(int id)
        {
            return _wrongAnswerDal.GetAll(x => x.QuestionId == id);
        }

        public void Update(WrongAnswer wrongAnswer)
        {
            _wrongAnswerDal.Update(wrongAnswer);
        }
    }
}
