using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Subject:IEntity
    {
        public int SubjectId { get; set; }
        public int UnitId { get; set; }
        public string SubjectName { get; set; }
    }
}
