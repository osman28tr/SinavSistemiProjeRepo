using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Student:IEntity
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentMail { get; set; }
        public string StudentPassword { get; set; }
        public string StudentNo { get; set; }
    }
}
