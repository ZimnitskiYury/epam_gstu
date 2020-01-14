using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures;

namespace Factory.Tests
{
    [TestClass()]
    public class FigureFactoryTests
    {
        [TestMethod()]
        
        public void CreateFigureTest()
        {
            FigureFactory factory = new FigureFactory();
            IFigure f1=factory.CreateFigure(Material.Film, Form.Square, 4f);
            Assert.AreEqual(16f, f1.Area);
        }
    }
}