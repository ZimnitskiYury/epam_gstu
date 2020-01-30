using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    public class Student
    {
        private DateTime dateofbirth;
        private GenderType gender;

        public Student(int id, string fullName, DateTime dateofBirth,  Group groupId, GenderType gender)
        {
            Id = id;
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            DateofBirth = dateofBirth;
            Gender = gender;
            GroupId = groupId ?? throw new ArgumentNullException(nameof(groupId));
        }
        public int Id { get;}
        public string FullName { get; set; }
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
        public Group GroupId { get; set; }
    }
}
