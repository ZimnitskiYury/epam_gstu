using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    [Table(Name = "StudentGrade")]
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
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "StudentID")]
        public Student StudentId {get;set;}
        [Column(Name = "Grade")]
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
        [Column(Name = "ExaminationID")]
        public Examination ExamId { get; set; }

    }
}
