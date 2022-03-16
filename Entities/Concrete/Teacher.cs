using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Teacher:IEntity
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string TeacherMail { get; set; }
        public string TeacherPassword { get; set; }
        public string TeacherTel { get; set; }
    }
}
