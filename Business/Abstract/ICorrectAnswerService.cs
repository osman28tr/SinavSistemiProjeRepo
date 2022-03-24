using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICorrectAnswerService
    {
        List<CorrectAnswer> GetAll();
        CorrectAnswer Get(int id);
        void Add(CorrectAnswer correctAnswer);
        void Update(CorrectAnswer correctAnswer);
        void Delete(CorrectAnswer correctAnswer);
    }
}
