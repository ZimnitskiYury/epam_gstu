using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    [Table(Name = "Group")]
    public class Group
    {

        [Column(Name = "SpecialityID")]
        public int SpecialityID { get; set; }
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }
        #region specialityid
        [Association(Storage = "_Speciality", ThisKey = "SpecialityID", IsForeignKey = true)]
        public Speciality Speciality
        {
            get { return this._Speciality.Entity; }
            set { this._Speciality.Entity = value; }
        }

        private EntityRef<Speciality> _Speciality;
        #endregion
        #region studentid
        private EntitySet<Student> _Students;
        
        [Association(OtherKey = "GroupID", Storage = "_Students")]
        public EntitySet<Student> Students
        {
            get { return this._Students; }
            set { this._Students.Assign(value); }
        }
        #endregion
        #region examinationid
        private EntitySet<Examination> _Examinations;

        [Association(OtherKey = "GroupID", Storage = "_Examinations")]
        public EntitySet<Examination> Examinations
        {
            get { return this._Examinations; }
            set { this._Examinations.Assign(value); }
        }
        #endregion
        public Group()
        {
            this._Examinations = new EntitySet<Examination>();
            this._Students = new EntitySet<Student>();
            _Speciality = default(EntityRef<Speciality>);
        }

        public Group(int id, string name, Speciality speciality)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Speciality = speciality ?? throw new ArgumentNullException(nameof(speciality));
        }
    }
}
