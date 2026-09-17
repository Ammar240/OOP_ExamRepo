using OOPExam.ExamClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam.SubjectClass;

internal class Subject
{
    public int SubjectID { get; set; }
    public string Name { get; set; }
    public Exam Exam { get; set; }

    public void CreatePracticalExam()
    {
        Exam = new PracticalExam();
    }
    public void CreateFinalExam()
    {
        Exam = new FinalExam();
    }
}
