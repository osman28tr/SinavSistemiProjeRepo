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
    public class LessonManager : ILessonService
    {
        ILessonDal _lessonDal;
        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }
        public void Add(Lesson lesson)
        {
            _lessonDal.Add(lesson);
        }

        public void Delete(Lesson lesson)
        {
            _lessonDal.Delete(lesson);
        }

        public Lesson Get()
        {
            return _lessonDal.Get();
        }

        public List<Lesson> GetAll()
        {
            return _lessonDal.GetAll();
        }

        public void Update(Lesson lesson)
        {
            _lessonDal.Update(lesson);
        }
    }
}
