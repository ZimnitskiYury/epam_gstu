using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    public class StudentGrade
    {
        int grade;
        public StudentGrade(int id, Examination examId, Student studentId, int grade)
        {
            Id = id;
            StudentId = studentId ?? throw new ArgumentNullException(nameof(studentId));
            Grade = grade;
            ExamId = examId ?? throw new ArgumentNullException(nameof(examId));
        }
        public int Id { get; set; }
        public Student StudentId {get;set;}
        public int Grade
        {
            get => grade; 
            set
            {
                if (value < 0 && value > 100)
                {
                    throw new Exception("Wrong grade");
                }
                grade = value;
            }
        }
        public Examination ExamId { get; set; }

    }
}
