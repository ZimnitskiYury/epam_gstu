using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    [Table(Name = "Examination")]
    public class Examination
    {
        public Examination(int id, DateTime date, Subject subjectId, ExamType exam, Group groupId, Session sessionId, Mentor mentorId)
        {
            Id = id;
            Date = date;
            SubjectId = subjectId ?? throw new ArgumentNullException(nameof(subjectId));
            Exam = exam;
            GroupId = groupId ?? throw new ArgumentNullException(nameof(groupId));
            SessionId = sessionId ?? throw new ArgumentNullException(nameof(sessionId));
            MentorId = mentorId ?? throw new ArgumentNullException(nameof(mentorId));
        }
        [Column(Name = "MentorID")]
        public Mentor MentorId { get; set; }
        [Column(Name= "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Date")]
        public DateTime Date { get; set; }
        [Column(Name = "SubjectID")]
        public Subject SubjectId { get; set; }
        [Column(Name = "TypeID")]
        public ExamType Exam { get; set; }
        [Column(Name = "GroupID")]
        public Group GroupId { get; set; }
        [Column(Name = "SessionID")]
        public Session SessionId { get; set; }
    }
}
