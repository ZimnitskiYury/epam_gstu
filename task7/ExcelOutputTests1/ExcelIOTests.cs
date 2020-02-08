using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExcelOutput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataReport;
using StudentsAndGrades;
using dbDao;

namespace ExcelOutput.Tests
{
    [TestClass()]
    public class ExcelIOTests
    {
        [TestMethod()]
        public void OutputTest()
        {
            var report = new Report();
            var ses = new SessionDao();
            var s1 = ses.Read(1);
            var ex = new ExcelIO();
            ex.Output(report.GetAvgGradeBySpecialities(s1), @"C:\Users\lenni\source\repos\ZimnitskiYury\epam_gstu\task7\output5.xlsx");
            Assert.Fail();
        }
    }
}