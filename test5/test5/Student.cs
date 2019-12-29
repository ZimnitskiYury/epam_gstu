using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    public class Student:IComparable
    {
        string studentName;
        string testTitle;
        int grade;
        DateTime dateTest;
        public string StudentName
        {
            get => studentName;
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("Wrong Name of Student");
                }
                else
                {
                    studentName = value;
                }
            }
        }
        public string TestTitle
        {
            get => testTitle;
            set {
                if (value.Length < 1)
                {
                    throw new Exception("Wrong Title of test");
                }
                else
                {
                    testTitle = value;
                }
            }
        }
        public int Grade
        {
            get => grade;
            set
            {
                if (value < 0 || value > 100)
                { 
                    throw new Exception("Wrong grade"); 
                }
                else
                { 
                    grade = value; 
                }
            }
        }
        public DateTime DateTest
        {
            get => dateTest;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new Exception("Wrong Date and/or Time");
                }
                else
                {
                    dateTest = value;
                }
            }
        }
        public Student (string name, int gr, string test, DateTime date)
        {
            StudentName = name;
            Grade = gr;
            TestTitle = test;
            DateTest = date;
        }

        public int CompareTo(object obj)
        {
            if (obj is Student c) 
            {
                return Grade.CompareTo(c.Grade);
            }
            else throw new Exception("Wrong Student for Compare");
        }
    }
}
