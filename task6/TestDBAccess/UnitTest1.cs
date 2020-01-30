using Microsoft.VisualStudio.TestTools.UnitTesting;
using dbDao;
using System.Data.Linq;
using StudentsAndGrades;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using DataReport;

namespace TestDBAccess
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StudentDao()
        {
        }
        [TestMethod]
        public void StudentReports()
        {
            var session = new SessionDao();
            var group = new GroupDao();
            ReportSession rs = new ReportSession();
            var result = rs.GetResults(session.Read(1), group.Read(1));
        }
    }
}
