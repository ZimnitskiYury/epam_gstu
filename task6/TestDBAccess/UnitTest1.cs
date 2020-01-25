using Microsoft.VisualStudio.TestTools.UnitTesting;
using dbDao;
using System.Data.Linq;
using StudentsAndGrades;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace TestDBAccess
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student student = new Student(915010, "Yury Zimniy", new DateTime(1987, 11, 7), GenderType.Male, 1);
            StudentDao student1 = new StudentDao();
            student1.Create(student);
            List<Student> st = new List<Student>();
            st = student1.GetAll();
            Session session = new Session(new DateTime(2007, 10, 12), new DateTime(2008, 11, 13));
            SessionDao session1 = new dbDao.SessionDao();
            session1.Create(session);
            List<Session> ses = new List<Session>();
            ses = session1.GetAll();
        } 
    }
}
