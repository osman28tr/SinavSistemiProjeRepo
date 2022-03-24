﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CorrectAnswer:IEntity
    {
        public int CorrectAnswerId { get; set; }
        public int QuestionId { get; set; }
        public string CorrectAnswerName { get; set; }
    }
}
