using Microsoft.VisualStudio.TestTools.UnitTesting;
using dbDao;
using System.Data.Linq;
using StudentsAndGrades;
using System;

namespace TestDBAccess
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student student = new Student(90010, "Yury Zimniy", new DateTime(27, 11, 7), GenderType.Male, 1);
            DbFactory<Student> db = new DbFactory<Student>();
            db.Create(student);
        }
    }
}
