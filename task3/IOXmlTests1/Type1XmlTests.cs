using Microsoft.VisualStudio.TestTools.UnitTesting;
using IOXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;
using Box;

namespace IOXml.Tests
{
    [TestClass()]
    public class Type1XmlTests
    {
        [TestMethod()]       
        public void WriteTest()
        {
            FigureFactory factory = new FigureFactory();
            BoxofFigures figures = new BoxofFigures();
            float[] vs = new float[]{ 3f,2f};
            float[] vs1 = new float[] { 31f };
            float[] vs2 = new float[] { 3f, 2.1f, 5f };
            float[] vs3 = new float[] { 11f };
            float[] vs4 = new float[] { 17f, 0.9f };
            float[] vs5 = new float[] { 9f, 7f };
            float[] vs6 = new float[] { 7f };
            float[] vs7 = new float[] { 7.3f, 19.2f };
            float[] vs8 = new float[] { 5f, 2f ,6.2f};
            float[] vs9 = new float[] { 3.7f, 2.51f };
            float[] vs10 = new float[] { 11f, 22f };
            figures.AddFigure(factory.CreateFigure(Material.Film, Form.Rectangle, vs));
            figures.AddFigure(factory.CreateFigure(Material.Paper, Form.Circle, vs1));
            figures.AddFigure(factory.CreateFigure(Material.Film, Form.Triangle, vs2));
            figures.AddFigure(factory.CreateFigure(Material.Film, Form.Square, vs3));
            figures.AddFigure(factory.CreateFigure(Material.Paper, Form.Rectangle, vs4));
            figures.AddFigure(factory.CreateFigure(Material.Paper, Form.Rectangle, vs5));
            figures.AddFigure(factory.CreateFigure(Material.Paper, Form.Square, vs6));
            figures.AddFigure(factory.CreateFigure(Material.Paper, Form.Rectangle, vs7));
            figures.AddFigure(factory.CreateFigure(Material.Film, Form.Triangle, vs8));
            figures.AddFigure(factory.CreateFigure(Material.Paper, Form.Rectangle, vs9));
            figures.AddFigure(factory.CreateFigure(Material.Film, Form.Rectangle, vs10));
            figures.SaveXMLAll("output_1_all.xml");
            figures.SaveXMLFilm("output_1_film.xml");
            figures.SaveXMLPaper("output_1_paper.xml");
            figures.SaveXML2All("output_2_all.xml");
            figures.SaveXML2Film("output_2_film.xml");
            figures.SaveXML2Paper("output_2_paper.xml");
            figures.LoadXML("input1.xml");
            figures.LoadXML2("input2.xml");
            figures.SaveXMLAll("output_i1_all.xml");
            figures.SaveXML2All("output_i2_all.xml");
            Assert.IsNotNull(figures);
        }
    }
}