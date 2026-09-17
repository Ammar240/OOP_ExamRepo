using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam.QuestionClasses
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }

        List<Answer> Answers = new List<Answer>();
        public Answer CorrectAnswer { get; set; }
    }
}
