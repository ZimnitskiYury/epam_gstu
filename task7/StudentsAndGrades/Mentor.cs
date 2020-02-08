using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    [Table(Name = "Mentor")]
    public class Mentor
    {
        public Mentor(int id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "FullName")]
        public string Name { get; set; }
        #region examinationid
        private EntitySet<Examination> _Examinations;

        [Association(OtherKey = "MentorID", Storage = "_Examinations")]
        public EntitySet<Examination> Examinations
        {
            get { return this._Examinations; }
            set { this._Examinations.Assign(value); }
        }
        #endregion
        public Mentor()
        {
            this._Examinations = new EntitySet<Examination>();
        }
    }
}
