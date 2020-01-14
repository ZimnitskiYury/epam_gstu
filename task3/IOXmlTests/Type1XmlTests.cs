using NUnit.Framework;
using IOXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;
using Figures;
using Box;

namespace IOXml.Tests
{
    [TestFixture()]
    public class Type1XmlTests
    {
        [TestCase()]
        public void Test()
        {
            FigureFactory f1 = new FigureFactory();
            BoxofFigures bf = new BoxofFigures();
            float[] ms = new float[]{2f,3f};
            IFigure figure = f1.CreateFigure(Material.Paper, Form.Rectangle, ms);
            bf.AddFigure(figure);
            bf.SaveXML2All();
            Assert.Pass();
        }
    }
}