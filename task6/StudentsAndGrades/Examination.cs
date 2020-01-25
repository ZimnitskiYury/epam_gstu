using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    class Examination
    {
        public Examination(DateTime date, Subject subject, ExamType examType, Group group, Session session)
        {
            this.date = date;
            this.subject = subject ?? throw new ArgumentNullException(nameof(subject));
            this.examType = examType;
            Group = group ?? throw new ArgumentNullException(nameof(group));
            Session = session ?? throw new ArgumentNullException(nameof(session));
        }

        public int Id { get; set; }
        public DateTime date { get; set; }
        public Subject subject { get; set; }
        public ExamType examType { get; set; }
        public Group Group { get; set; }
        public Session Session { get; set; }
    }
}
