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
            Box bx = new Box();
            Circle rect = new Circle("paper", "red", 10);
            Circle rect2 = new Circle("paper", "red", 10);
            bx.LoadXML();
            bx.SaveXMLAll();
            
 
            Assert.AreEqual(rect, rect2);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}