using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Figures.Film;
using Figures;

namespace Factory.Tests
{
    [TestFixture]
    public class FigureFactoryTests
    {
        Material material = Material.Film;
        Form form = Form.Square;
        FigureFactory ff1 = new FigureFactory();
        [TestCase(12f, 4f, 3f)]
        public void Area(float expectArea, params float[] values)
        {
            IFigure figure = ff1.CreateFigure(material, form, values);

            Assert.AreEqual(expectArea, figure.Area, 0.00001f);
        }
    }
}