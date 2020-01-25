using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    public class Group
    {
        public Group(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
