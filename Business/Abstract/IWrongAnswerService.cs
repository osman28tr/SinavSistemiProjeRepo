using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWrongAnswerService
    {
        List<WrongAnswer> GetAll(int id);
        WrongAnswer Get();
        List<string> Add(WrongAnswer wrongAnswer);
        IList<ValidationFailure> Dogrula(WrongAnswer wrongAnswer);
        void Update(WrongAnswer wrongAnswer);
        void Delete(WrongAnswer wrongAnswer);
    }
}
