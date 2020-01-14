using NUnit.Framework;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace Factory.Tests
{
    [TestFixture()]
    public class FigureFactoryTests
    {
        FigureFactory f1 = new FigureFactory();
        [TestCase(16f, 0, 2, 4f)] //Square
        [TestCase(28f, 0, 2, 7f)]
        [TestCase(36f, 0, 2, 9f)]
        [TestCase(4f, 0, 2, 1f)]
        [TestCase(10f, 0, 2, 2.5f)]
        [TestCase(13.2f, 0, 2, 3.3f)]
        [TestCase(4.4f, 0, 2, 1.1f)]
        [TestCase(2.8f, 0, 2, 0.7f)]
        [TestCase(12.56f, 0, 0, 4f)] //Circle
        [TestCase(21.98f, 0, 0, 7f)]
        [TestCase(28.26f, 0, 0, 9f)]
        [TestCase(3.14f, 0, 0, 1f)]
        [TestCase(7.85f, 0, 0, 2.5f)]
        [TestCase(10.362f, 0, 0, 3.3f)]
        [TestCase(3.454f, 0, 0, 1.1f)]
        [TestCase(2.198f, 0, 0, 0.7f)]
        public void PerimeterTest(float expected, Material material, Form form, params float[] ps)
        {
            IFigure figure = f1.CreateFigure(material, form, ps);
            Assert.AreEqual(expected, figure.Perimeter, 0.1f);
        }
        [TestCase(16f, 1, 2, 4f)] //Square
        [TestCase(49f, 1, 2, 7f)]
        [TestCase(81f, 1, 2, 9f)]
        [TestCase(1f, 1, 2, 1f)]
        [TestCase(6.25f, 1, 2, 2.5f)]
        [TestCase(10.89f, 1, 2, 3.3f)]
        [TestCase(1.21f, 1, 2, 1.1f)]
        [TestCase(0.49f, 1, 2, 0.7f)]
        [TestCase(12.56f, 0, 0, 4f)] //Circle
        [TestCase(38.465f, 0, 0, 7f)]
        [TestCase(63.585f, 0, 0, 9f)]
        public void AreaTest(float expected, Material material, Form form, params float[] ps)
        {
            IFigure figure = f1.CreateFigure(material, form, ps);
            Assert.AreEqual(expected, figure.Area, 0.1f);
        }
    }
}