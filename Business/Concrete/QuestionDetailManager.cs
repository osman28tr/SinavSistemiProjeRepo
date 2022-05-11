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

        public void Add(QuestionDetail questionDetail)
        {
            _questionDetailDal.Add(questionDetail);
        }
        public void Delete(QuestionDetail questionDetail)
        {
            _questionDetailDal.Delete(questionDetail);
        }

        public int FalseAnswerCount(int ogrid) //ilgili öğrenciye ait yanlış çözülen soruların sayısını veriyor.
        {
            return _questionDetailDal.GetAll(x => x.StudentId == ogrid && x.QuestionState == false && x.AnsweredState == true).Count;
        }

        public QuestionDetail Get(int questiondetailid)
        {
            return _questionDetailDal.Get(x => x.QuestionDetailId == questiondetailid);
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

        public List<QuestionDetail> GetQuestionsAnsweredByDate(int studentid, Sigma sigma) //6 sigma yaklaşımının uygulanması
        {
            var questions = _questionDetailDal.GetAll(x => x.QuestionState == true && x.StudentId == studentid).ToList();
            var questionsDate = questions.Select(x => x.AnsweredDate).ToList();
            int questionvalues = questionsDate.Count();
            List<QuestionDetail> questiondetailList = new List<QuestionDetail>();
            for (int i = 0; i < questionvalues; i++)
            {
                TimeSpan timeSpan = DateTime.Now - questionsDate[i];
                if (timeSpan.Days == sigma.Sigma1 || timeSpan.Days == sigma.Sigma2 || timeSpan.Days == sigma.Sigma3 || timeSpan.Days == sigma.Sigma4 || timeSpan.Days == sigma.Sigma5 || timeSpan.Days == sigma.Sigma6)
                {
                    questiondetailList.Add(questions[i]);
                }
            }
            return questiondetailList;
        }

        public List<QuestionDetail> GetQuestionsByFalse(int studentid) //ilgili öğrenciye ait yanlış bilinen soruların getirilmesi
        {
            return _questionDetailDal.GetAll(x => x.QuestionState == false && x.StudentId == studentid);
        }

        public List<QuestionDetail> GetQuestionsByFalseAndAnswered(int studentid)
        {
            return _questionDetailDal.GetAll(x => x.QuestionState == false && x.StudentId == studentid && x.AnsweredState == true);
        }

        public int StudentEmptyQuestionBySubject(int questionId, int studentId) //ilgili öğrenciye ait çözülmeyen bir sorunun getirilmesi
        {
            if (_questionDetailDal.Get(x => x.QuestionId == questionId && x.StudentId == studentId && x.AnsweredState == false) != null)
            {
                return 1;
            }
            else
                return 0;
        }

        public int StudentNotSuccessQuestionBySubject(int questionId, int studentId) //ilgili öğrenciye ait yanlış çözülen sorunun getirilmesi
        {
            if (_questionDetailDal.Get(x => x.QuestionId == questionId && x.StudentId == studentId && x.QuestionState == false && x.AnsweredState == true) != null)
            {
                return 1;
            }
            else
                return 0;
        }

        public int StudentSuccessQuestionBySubject(int questionId, int studentId)
        {
            if (_questionDetailDal.Get(x => x.QuestionId == questionId && x.StudentId == studentId && x.QuestionState == true && x.AnsweredState == true) != null)
            {
                return 1;
            }
            else
                return 0;
        }

        public int TrueAnswerCount(int ogrid) //ilgili öğrenciye ait doğru bilinen soruların sayısının getirilmesi
        {
            return _questionDetailDal.GetAll(x => x.StudentId == ogrid && x.QuestionState == true && x.AnsweredState == true).Count;
        }

        public void Update(QuestionDetail questionDetail)
        {
            _questionDetailDal.Update(questionDetail);
        }
    }
}
