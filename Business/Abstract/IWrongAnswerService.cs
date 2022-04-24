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
        WrongAnswer Get(int id);
        void Add(WrongAnswer wrongAnswer);
        void Update(WrongAnswer wrongAnswer);
        void Delete(WrongAnswer wrongAnswer);
    }
}
