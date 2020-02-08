using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    [Table(Name = "Student")]
    public class Student
    {
        private DateTime dateofbirth;
        private GenderType gender;
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "FullName")]
        public string FullName { get; set; }
        [Column(Name = "DateofBirth")]
        public DateTime DateofBirth
        {
            get=> dateofbirth;
            set
            {
                if (((DateTime.Now - value).Days / 365) <= 13)
                {
                    throw new Exception("Student under 13 years old");
                }
                else dateofbirth = value;
            }
        }
        [Column(Name = "Gender")]
        public GenderType Gender
        {
            get=>gender;
            set
            {
                if (value != GenderType.Male && value != GenderType.Female)
                {
                    throw new Exception("Wrong Gender");
                }
                else gender = value;
            }
        }
        [Column(Name = "GroupID")]
        public int GroupID { get; set; }
        #region studentgrade
        private EntitySet<StudentGrade> _StudentGrades;

        [Association(OtherKey = "StudentID", Storage = "_StudentGrades")]
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
        public Student()
        {
            _Groups = default(EntityRef<Group>);
            this._StudentGrades = new EntitySet<StudentGrade>();
        }
    }
}
