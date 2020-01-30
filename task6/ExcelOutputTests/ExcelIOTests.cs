using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExcelOutput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataReport;
using dbDao;

namespace ExcelOutput.Tests
{
    [TestClass()]
    public class ExcelIOTests
    {
        [TestMethod()]
        public void OutputTest()
        {
            var student = new StudentDao();
            var session = new SessionDao();
            var group = new GroupDao();
            var report = new Report();
            var ex = new ExcelIO();
            ex.Output(report.GetResults(session.Read(1), group.Read(2)), @"C:\Users\lenni\source\repos\ZimnitskiYury\epam_gstu\task6\output.xlsx");
            ex.Output(report.GetGrades(session.Read(1)), @"C:\Users\lenni\source\repos\ZimnitskiYury\epam_gstu\task6\output2.xlsx");
            ex.Output(report.GetExpelledBySession(session.Read(1), 50), @"C:\Users\lenni\source\repos\ZimnitskiYury\epam_gstu\task6\output3.xlsx");
            Assert.Fail();
        }
    }
}