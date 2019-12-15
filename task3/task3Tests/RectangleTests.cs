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
            Circle rect = new Circle("paper", "red", 10);
            Circle rect2 = new Circle("paper", "red", 4);
            Box bo = new Box();
            bo.AddFigure(rect);
            bo.AddFigure(rect2);

            bool b1 = (bo.ViewFigure(0)).Equals(bo.ViewFigure(1));
            Assert.AreEqual(b1, rect.ToString());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}