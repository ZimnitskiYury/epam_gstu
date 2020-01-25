using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGrades
{
    public class Student
    {
        DateTime dateofbirth;

        public Student(string fullName, DateTime dateofBirth, GenderType gender, Group groupId)
        {
            FullName = fullName;
            DateofBirth = dateofBirth;
            Gender = gender;
            GroupId = groupId;
        }

        int Id { get; set; }
        string FullName { get; set; }
        DateTime DateofBirth
        {
            get => dateofbirth;
            set
            {
                if (((DateTime.Now - value).Days / 365) <= 13)
                {
                    throw new Exception("Student under 13 years old");
                }
                else dateofbirth = value;
            }
        }
        GenderType Gender
        {
            get=>Gender;
            set
            {
                if (value != GenderType.Male && value != GenderType.Female)
                {
                    throw new Exception("Wrong Gender");
                }
                else Gender = value;
            }
        }
        public Group GroupId { get; set; }
    }
}
