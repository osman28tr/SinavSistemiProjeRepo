using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IQuestionDetailService
    {
        List<QuestionDetail> GetAll();
        QuestionDetail Get(int questiondetailid);
        void Add(QuestionDetail questionDetail);
        void Update(QuestionDetail questionDetail);
        void Delete(QuestionDetail questionDetail);
        int GetQuestionDetailId(int questionId, int studentId);
        List<QuestionDetail> GetQuestionsAnsweredByDate(int studentid, Sigma sigma);
        List<QuestionDetail> GetQuestionsByFalse(int studentid);
        List<QuestionDetail> GetQuestionsByFalseAndAnswered(int studentid);
        int TrueAnswerCount(int ogrid);
        int FalseAnswerCount(int ogrid);
        int StudentSuccessQuestionBySubject(int questionId, int studentId);
        int StudentNotSuccessQuestionBySubject(int questionId, int studentId);
        int StudentEmptyQuestionBySubject(int questionId, int studentId);
    }
}
