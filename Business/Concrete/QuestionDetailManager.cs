using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class QuestionDetailManager : IQuestionDetailService
    {
        IQuestionDetailDal _questionDetailDal;
        public QuestionDetailManager(IQuestionDetailDal questionDetailDal)
        {
            _questionDetailDal = questionDetailDal;
        }

        public void Add(QuestionDetail questionDetail, int id)
        {
            if (_questionDetailDal.Get(x => x.QuestionDetailId == id) == null) //bir öğrenciye aynı soru gelebilir bidaha boşa detail eklemesin
                _questionDetailDal.Add(questionDetail);
        }
        public void Delete(QuestionDetail questionDetail)
        {
            _questionDetailDal.Delete(questionDetail);
        }

        public QuestionDetail Get()
        {
            return _questionDetailDal.Get();
        }

        public List<QuestionDetail> GetAll()
        {
            return _questionDetailDal.GetAll();
        }

        public int GetQuestionDetailId(int questionId, int studentId)
        {
            if (_questionDetailDal.Get(x => x.QuestionId == questionId && x.StudentId == studentId) == null)
                return 0;
            return _questionDetailDal.Get(x => x.QuestionId == questionId && x.StudentId == studentId).QuestionDetailId;
        }

        public void Update(QuestionDetail questionDetail)
        {
            _questionDetailDal.Update(questionDetail);
        }
    }
}
