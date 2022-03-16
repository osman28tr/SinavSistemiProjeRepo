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
    public class UnitManager:IUnitService
    {
        IUnitDal _unitDal;
        public UnitManager(IUnitDal unitDal)
        {
            _unitDal = unitDal;
        }

        public List<Unit> GetAllById(int id)
        {
            return _unitDal.GetAll(x => x.LessonId == id).ToList();
        }

        public List<Unit> GetUnitsByLesson(int lessonid)
        {
            var units = _unitDal.GetAll(x => x.LessonId == lessonid).ToList();
            return units;
        }
    }
}
