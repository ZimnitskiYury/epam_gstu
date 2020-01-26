using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    public class StudentGrade
    {
        public StudentGrade(Student student, int grade, Examination exam)
        {
            StudentID = student ?? throw new ArgumentNullException(nameof(student));
            Grade = grade;
            Exam = exam ?? throw new ArgumentNullException(nameof(exam));
        }
        public int Id { get; set; }
        public Student StudentID {get;set;}
        public int Grade { get; set; }
        public Examination Exam { get; set; }

    }
}
