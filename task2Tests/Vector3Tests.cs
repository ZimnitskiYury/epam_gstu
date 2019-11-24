using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Tests
{
    [TestClass()]
    public class Vector3Tests
    {
        [TestMethod()]
        public void Vector3Test()
        {
            Vector3 v1 = new Vector3(2,2.0f,2);
            Vector3 v2 = new Vector3(2);
            string str1 = v1.ToString();
            string str2 = v2.ToString();
            double k=v1.GetLength();
            Assert.AreEqual(str1, str2);
        }

        [TestMethod()]
        public void Vector3Test1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Vector3Test2()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetLengthTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetScalarTest()
        {
            Assert.Fail();
        }
    }
}