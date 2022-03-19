using Entities.Concrete;
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
        Question Get();
        void Add(Question question);
        void Update(Question question);
        void Delete(Question question);
        List<Question> GetQuestionsByNotAnswered(List<QuestionDetail> questionDetails);
        List<Question> GetQuestionsByAnswered(List<QuestionDetail> questionDetails);
    }
}
