using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    [Table(Name = "Group")]
    public class Group
    {
        public Group(int id, string name, Speciality specialityID)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            SpecialityID = specialityID ?? throw new ArgumentNullException(nameof(specialityID));
        }
        [Column(Name = "SpecialityID")]
        public Speciality SpecialityID { get; set; }
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }

    }
}
