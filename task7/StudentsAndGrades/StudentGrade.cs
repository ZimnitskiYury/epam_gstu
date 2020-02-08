using System;
using System.Collections.Generic;
using System.Data.Linq;
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
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "StudentID")]
        public int StudentID {get;set;}
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
        public int ExaminationID { get; set; }

        #region examinationid
        [Association(Storage = "_Examination", ThisKey = "ExaminationID", IsForeignKey = true)]
        public Examination Examination
        {
            get { return this._Examination.Entity; }
            set { this._Examination.Entity = value; }
        }

        private EntityRef<Examination> _Examination;

        #endregion
        #region studentid
        [Association(Storage = "_Student", ThisKey = "StudentID", IsForeignKey = true)]
        public Student Student
        {
            get { return this._Student.Entity; }
            set { this._Student.Entity = value; }
        }

        private EntityRef<Student> _Student;

        #endregion
        public StudentGrade()
        {
            _Student = default(EntityRef<Student>);
            _Examination = default(EntityRef<Examination>);
        }
    }
}
