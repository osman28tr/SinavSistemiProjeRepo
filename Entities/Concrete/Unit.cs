using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Unit:IEntity
    {
        public int UnitId { get; set; }
        public int LessonId { get; set; }
        public string UnitName { get; set; }
    }
}
