using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Question:IEntity
    {
        public int QuestionId { get; set; }
        public int SubjectId { get; set; }
        public string QuestionName { get; set; }
        public string PicturePath { get; set; }
        public string QuestionCorrectAnswer { get; set; }
        public string QuestionWrongAnswer1 { get; set; }
        public string QuestionWrongAnswer2 { get; set; }
        public string QuestionWrongAnswer3 { get; set; }
        public bool ConfirmState { get; set; }

    }
}
