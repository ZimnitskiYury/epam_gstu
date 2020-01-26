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
        public Student(long creditBook, string fullName, DateTime dateofBirth, GenderType gen, Group groupId)
        {
            CreditBook = creditBook;
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            DateofBirth = dateofBirth;
            Gender = gen;
            GroupId = groupId;
        }
        public long CreditBook { get; set; }
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
            get=>gender;
            set
            {
                if (value != GenderType.Male && value != GenderType.Female)
                {
                    throw new Exception("Wrong Gender");
                }
                else gender = (GenderType)value;
            }
        }
        public Group GroupId { get; set; }
    }
}
