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

        public Student(int creditBook, string fullName, DateTime dateofBirth, GenderType gender, int groupId)
        {
            CreditBook = creditBook;
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            DateofBirth = dateofBirth;
            Gender = gender;
            GroupId = groupId;
        }

        public int CreditBook { get; set; }
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateofBirth
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
        public GenderType Gender
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
        public int GroupId { get; set; }
    }
}
