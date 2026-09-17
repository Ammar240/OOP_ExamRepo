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

    //public int Time { get; set; }
    //public int NumOfQuestions { get; set; }
    //public List<Question> Questions { get; set; }


    public override void CreateExam(List<Question> questionList)
    {
        
    }

    public override void ShowExam()
    {
      
    }
}
