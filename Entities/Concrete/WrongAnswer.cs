using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class WrongAnswer:IEntity
    {
        public int WrongAnswerId { get; set; }
        public int QuestionId { get; set; }
        public string WrongAnswerName { get; set; }
    }
}
