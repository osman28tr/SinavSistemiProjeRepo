using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public WrongAnswerManager(IWrongAnswerDal wrongAnswerDal)
        {
            _wrongAnswerDal = wrongAnswerDal;
        }
        public void Add(WrongAnswer wrongAnswer)
        {
            _wrongAnswerDal.Add(wrongAnswer);
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
