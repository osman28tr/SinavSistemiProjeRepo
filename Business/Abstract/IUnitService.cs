using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUnitService
    {
        List<Unit> GetUnitsByLesson(int lessonid);
        List<Unit> GetAllById(int id);
    }
}
