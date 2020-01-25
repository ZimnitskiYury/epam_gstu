using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    public class StudentGrade
    {
        public StudentGrade(Student student, Subject subject, Session session, int grade)
        {
            Student = student ?? throw new ArgumentNullException(nameof(student));
            Subject = subject ?? throw new ArgumentNullException(nameof(subject));
            Session = session ?? throw new ArgumentNullException(nameof(session));
            Grade = grade;
        }

        public int Id { get; set; }
        public Student Student {get;set;}
        public Subject Subject { get; set; }
        public Session Session { get; set; }
        public int Grade { get; set; }

    }
}
