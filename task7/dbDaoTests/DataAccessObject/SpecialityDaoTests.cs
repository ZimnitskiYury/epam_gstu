using Microsoft.VisualStudio.TestTools.UnitTesting;
using dbDao.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndGrades;

namespace dbDao.DataAccessObject.Tests
{
    [TestClass()]
    public class SpecialityDaoTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            var spec = new Speciality(4, "Электронные узлы");
            var sp1 = new SpecialityDao();
            var specialit = sp1.Read(1);
            sp1.Create(spec);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var sp1 = new SpecialityDao();
            var specialit = sp1.Read(1);
            specialit.Name = "Прикладная информатика и право";
            sp1.Update(specialit);
            Assert.IsTrue(true);
        }
    }
}