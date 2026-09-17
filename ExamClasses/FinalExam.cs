using OOPExam.QuestionClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam.ExamClasses;

internal class FinalExam:Exam
{
    public TrueFalesQuestion TFQ { get; set; }
    public MCQ MCQ { get; set; }


}
