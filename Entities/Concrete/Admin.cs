using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Admin:IEntity
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminSurname { get; set; }
        public string AdminMail { get; set; }
        public string AdminPassword { get; set; }
    }
}
