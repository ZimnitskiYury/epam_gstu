using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    public class Examination
    {
        public Examination(DateTime date, Subject subjectId, ExamType exam, Group groupId, Session sessionId)
        {
            Date = date;
            SubjectId = subjectId ?? throw new ArgumentNullException(nameof(subjectId));
            Exam = exam;
            GroupId = groupId ?? throw new ArgumentNullException(nameof(groupId));
            SessionId = sessionId ?? throw new ArgumentNullException(nameof(sessionId));
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Subject SubjectId { get; set; }
        public ExamType Exam { get; set; }
        public Group GroupId { get; set; }
        public Session SessionId { get; set; }
    }
}
