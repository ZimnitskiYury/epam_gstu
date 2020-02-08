using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    [Table(Name = "Speciality")]
    public class Speciality
    {        
        public Speciality(int id, string name):this()
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }

        private EntitySet<Group> _Groups;

        [Association(OtherKey = "SpecialityID", Storage = "_Groups")]
        public EntitySet<Group> Groups
        {
            get { return this._Groups; }
            set { this._Groups.Assign(value); }
        }
        public Speciality()
        {
            this._Groups = new EntitySet<Group>();
        }
    }
}
