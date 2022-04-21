using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IQuestionService
    {
        List<Question> GetAll();
        int GetLastQuestionId();
        Question Get(int id);
        List<string> Add(Question question);
        IList<ValidationFailure> Dogrula(Question question);
        void Update(Question question);
        void Delete(Question question);
        List<Question> GetQuestionsByNotAnswered(List<QuestionDetail> questionDetails);
        List<Question> GetQuestionsByAnswered(List<QuestionDetail> questionDetails);
        List<Question> GetConfirmByQuestions();
        List<Question> GetNotConfirmByQuestions();
        List<Question> GetQuestionsByQuestionName(string questionName, int questionConfirmState);
        List<Question> GetQuestionsByState(int state);
        int QuestionBySubject(int subjectId);
    }
}
