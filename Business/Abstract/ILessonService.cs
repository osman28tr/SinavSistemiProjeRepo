using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILessonService
    {
        List<Lesson> GetAll();
        Lesson Get();
        void Add(Lesson lesson);
        void Update(Lesson lesson);
        void Delete(Lesson lesson);
    }
}
