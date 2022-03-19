using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class QuestionDetail:IEntity
    {
        public int QuestionDetailId { get; set; }
        public int QuestionId { get; set; }
        public int StudentId { get; set; }
        public bool QuestionState { get; set; }
        public DateTime AnsweredDate { get; set; }
        public int SigmaCount { get; set; }
    }
}
