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
    public class SubjectManager : ISubjectService
    {
        ISubjectDal _subjectDal;
        public SubjectManager(ISubjectDal subjectDal)
        {
            _subjectDal = subjectDal;
        }
        public List<Subject> GetAllById(int id)
        {
            return _subjectDal.GetAll(x => x.UnitId == id).ToList();
        }

        public List<Subject> GetSubjectsByUnit(int unitid)
        {
            return _subjectDal.GetAll(x => x.UnitId == unitid).ToList();
        }
    }
}
