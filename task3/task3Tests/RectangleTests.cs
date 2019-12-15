using Microsoft.VisualStudio.TestTools.UnitTesting;
using task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void RectangleTest()
        {
            Rectangle rect = new Rectangle("paper", "red", 10, 20);
            Rectangle rect2 = new Rectangle("paper", "red", 10, 20);
            bool b1 = rect.Equals(rect2);
            Assert.AreEqual(b1, true);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}