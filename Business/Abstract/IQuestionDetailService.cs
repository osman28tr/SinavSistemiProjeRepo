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
        QuestionDetail Get();
        void Add(QuestionDetail questionDetail, int id);
        void Update(QuestionDetail questionDetail);
        void Delete(QuestionDetail questionDetail);
        int GetQuestionDetailId(int questionId, int studentId);
    }
}
