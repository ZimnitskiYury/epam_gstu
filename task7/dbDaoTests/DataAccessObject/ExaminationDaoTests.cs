using Microsoft.VisualStudio.TestTools.UnitTesting;
using dbDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbDao.Tests
{
    [TestClass()]
    public class ExaminationDaoTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            var exams = new ExaminationDao();
            var full = exams.GetAll();
            Assert.IsNotNull(full);
        }
    }
}