using StudentsAndGrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReport
{
    public class ReportSession
    {
        public ReportSession(Session sessionId, Group groupId, Student studentId, Subject subjectId, ExamType examType, DateTime date, StudentGrade grade)
        {
            SessionId = sessionId ?? throw new ArgumentNullException(nameof(sessionId));
            GroupId = groupId ?? throw new ArgumentNullException(nameof(groupId));
            StudentId = studentId ?? throw new ArgumentNullException(nameof(studentId));
            SubjectId = subjectId ?? throw new ArgumentNullException(nameof(subjectId));
            ExamType = examType;
            Date = date;
            Grade = grade;
        }
        public Session SessionId { get; set; }
        public Group GroupId { get; set; }
        public Student StudentId { get; set; }
        public Subject SubjectId { get; set; }
        public ExamType ExamType { get; set; }
        public DateTime Date { get; set; }
        public StudentGrade Grade { get; set; }
    }
    public class ReportGroup
    {
        public ReportGroup(Group groupId, double averageGrade, int minGrade, int maxGrade)
        {
            GroupId = groupId ?? throw new ArgumentNullException(nameof(groupId));
            AverageGrade = averageGrade;
            MinGrade = minGrade;
            MaxGrade = maxGrade;
        }

        public Group GroupId { get; set; }
        public double AverageGrade { get; set; }
        public int MinGrade { get; set; }
        public int MaxGrade { get; set; }
    }
    public class ReportExpelledStudent
    {
        public ReportExpelledStudent(Student studentId, Group groupId, double averageGrade)
        {
            StudentId = studentId ?? throw new ArgumentNullException(nameof(studentId));
            GroupId = groupId ?? throw new ArgumentNullException(nameof(groupId));
            AverageGrade = averageGrade;
        }

        public Student StudentId { get; set; }
        public Group GroupId { get; set; }
        public double AverageGrade { get; set; }
    }
}
