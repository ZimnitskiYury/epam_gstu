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
        public void TestAdd()
        {
            Circle rect = new Circle("paper", "red", 11);
            Square rect2 = new Square("film", "transparent", 11);
            Rectangle rect3 = new Rectangle("film", "transparent", 11, 9);
            Triangle rect4 = new Triangle("film", "transparent", 11, 9,7);
            Box bx = new Box();
            bx.AddFigure(rect);
            bx.AddFigure(rect2, 1);
            bx.AddFigure(rect3, 0);
            bx.AddFigure(rect4);
            var result = bx.ViewFigure(0);
            var expected = bx.ViewFigure(1);
            bx.SaveXML2All();
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void RectangleTest()
        {
            Box bx = new Box();
            Circle rect = new Circle("paper", "red", 11);
            Circle rect2 = new Circle("paper", "red", 10);
            bx.AddFigure(rect);
            bx.AddFigure(rect2);
            bx.LoadXML2();
            bx.SaveXML2All();
            
 
            Assert.AreEqual(bx.ViewFigure(0), rect2);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}