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
    public class CorrectAnswerManager : ICorrectAnswerService
    {
        ICorrectAnswerDal _correctAnswerDal;
        public CorrectAnswerManager(ICorrectAnswerDal correctAnswerDal)
        {
            _correctAnswerDal = correctAnswerDal;
        }
        public void Add(CorrectAnswer correctAnswer)
        {
            _correctAnswerDal.Add(correctAnswer);
        }

        public void Delete(CorrectAnswer correctAnswer)
        {
            _correctAnswerDal.Delete(correctAnswer);
        }

        public CorrectAnswer Get(int id)
        {
            return _correctAnswerDal.Get(x => x.QuestionId == id);
        }

        public List<CorrectAnswer> GetAll()
        {
            return _correctAnswerDal.GetAll();
        }

        public void Update(CorrectAnswer correctAnswer)
        {
            _correctAnswerDal.Update(correctAnswer);
        }
    }
}
