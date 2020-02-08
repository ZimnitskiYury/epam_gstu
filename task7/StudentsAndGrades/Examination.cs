using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    [Table(Name = "Examination")]
    public class Examination
    {
        [Column(Name = "MentorID")]
        public int MentorId { get; set; }
        [Column(Name= "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Date")]
        public DateTime Date { get; set; }
        [Column(Name = "SubjectID")]
        public int SubjectId { get; set; }
        [Column(Name = "TypeID")]
        public ExamType Exam { get; set; }
        [Column(Name = "GroupID")]
        public int GroupId { get; set; }
        [Column(Name = "SessionID")]
        public int SessionId { get; set; }
        #region subjectid
        [Association(Storage = "_Subject", ThisKey = "SubjectID", IsForeignKey = true)]
        public Subject Subject
        {
            get { return this._Subject.Entity; }
            set { this._Subject.Entity = value; }
        }

        private EntityRef<Subject> _Subject;

        #endregion
        #region studentgrades
        private EntitySet<StudentGrade> _StudentGrades;

        [Association(OtherKey = "ExaminationID", Storage = "_StudentGrades")]
        public EntitySet<StudentGrade> StudentGrades
        {
            get { return this._StudentGrades; }
            set { this._StudentGrades.Assign(value); }
        }
        #endregion 
        #region groupid
        [Association(Storage = "_Groups", ThisKey = "GroupID", IsForeignKey = true)]
        public Group Groups
        {
            get { return this._Groups.Entity; }
            set { this._Groups.Entity = value; }
        }

        private EntityRef<Group> _Groups;

        #endregion
        #region sessionid
        [Association(Storage = "_Sessions", ThisKey = "SessionID", IsForeignKey = true)]
        public Session Sessions
        {
            get { return this._Sessions.Entity; }
            set { this._Sessions.Entity = value; }
        }

        private EntityRef<Session> _Sessions;

        #endregion
        #region mentorid
        [Association(Storage = "_Mentors", ThisKey = "MentorID", IsForeignKey = true)]
        public Mentor Mentors
        {
            get { return this._Mentors.Entity; }
            set { this._Mentors.Entity = value; }
        }

        private EntityRef<Mentor> _Mentors;

        #endregion
        public Examination()
        {
            _Mentors = default(EntityRef<Mentor>);
            _Sessions = default(EntityRef<Session>);
            _Subject = default(EntityRef<Subject>);
            _Groups = default(EntityRef<Group>);
            this._StudentGrades = new EntitySet<StudentGrade>();
        }               
    }
}
