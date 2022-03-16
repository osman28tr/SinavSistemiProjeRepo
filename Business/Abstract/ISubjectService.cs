using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISubjectService
    {
        List<Subject> GetAllById(int id);
        List<Subject> GetSubjectsByUnit(int unitid);
    }
}
