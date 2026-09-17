using OOPExam.QuestionClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam.ExamClasses;

internal abstract class Exam
{
    public int Time { get; set; }
    public int NumOfQuestions { get; set; }
    public List<Question> Questions { get; set; }

    public abstract void CreateExam(List<Question> questionList);
    public abstract void ShowExam();
}
