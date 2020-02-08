using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    [Table(Name = "Subject")]
    public class Subject
    {
        public Subject(int id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }

        private EntitySet<Examination> _Examinations;

        [Association(OtherKey = "SubjectID", Storage = "_Examenations")]
        public EntitySet<Examination> Examinations
        {
            get { return this._Examinations; }
            set { this._Examinations.Assign(value); }
        }
        public Subject()
        {
            this._Examinations = new EntitySet<Examination>();
        }
    }
}
