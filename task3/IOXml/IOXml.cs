using System.IO;
using System.Collections.Generic;
using System.Xml;
using System;
using Figures;
using Figures.BaseFigures;
using Figures.Film;
using Figures.Paper;
using Factory;

namespace IOXml
{
    /// <summary>
    /// StreamReader and StreamWriter
    /// </summary>
    public class Type1Xml
    {
        /// <summary>
        /// StreamWriter
        /// </summary>
        /// <param name="i">Input string</param>
        public void Write(string output, List<IFigure> figures)
        {
            StreamWriter sw = new StreamWriter(output, false, System.Text.Encoding.Default);
            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n<Box>\n";
            foreach (var k in figures)
            {
                if (k is RectangleFilm)
                {
                    xml += "\t<figure type=\"Rectangle\">\n";
                    xml += "\t\t<material>Film</material>\n";
                    xml += "\t\t<color>None</color>\n";
                    xml += "\t\t<height>" + ((RectangleFilm)k).Height + "</height>\n";
                    xml += "\t\t<width>" + ((RectangleFilm)k).Width + "</width>\n";
                    xml += "\t</figure>\n";
                }
                else if (k is CircleFilm)
                {
                    xml += "\t<figure type=\"Circle\">\n";
                    xml += "\t\t<material>Film</material>\n";
                    xml += "\t\t<color>None</color>\n";
                    xml += "\t\t<diameter>" + ((CircleFilm)k).Diameter + "</diameter>\n";
                    xml += "\t</figure>\n";
                }
                else if (k is SquareFilm)
                {
                    xml += "\t<figure type=\"Square\">\n";
                    xml += "\t\t<material>Film</material>\n";
                    xml += "\t\t<color>None</color>\n";
                    xml += "\t\t<height>" + ((SquareFilm)k).A + "</height>\n";
                    xml += "\t</figure>\n";
                }
                else if (k is TriangleFilm)
                {
                    xml += "\t<figure type=\"Triangle\">\n";
                    xml += "\t\t<material>Film</material>\n";
                    xml += "\t\t<color>None</color>\n";
                    xml += "\t\t<side_a>" + ((TriangleFilm)k).A + "</side_a>\n";
                    xml += "\t\t<side_b>" + ((TriangleFilm)k).B + "</side_b>\n";
                    xml += "\t\t<side_c>" + ((TriangleFilm)k).C + "</side_c>\n";
                    xml += "\t</figure>\n";
                }
                else if (k is RectanglePaper)
                {
                    xml += "\t<figure type=\"Rectangle\">\n";
                    xml += "\t\t<material>Paper</material>\n";
                    xml += "\t\t<color>" + ((RectanglePaper)k).Color.ToString() + "</color>\n";
                    xml += "\t\t<height>" + ((RectanglePaper)k).Height + "</height>\n";
                    xml += "\t\t<width>" + ((RectanglePaper)k).Width + "</width>\n";
                    xml += "\t</figure>\n";
                }
                else if (k is CirclePaper)
                {
                    xml += "\t<figure type=\"Circle\">\n";
                    xml += "\t\t<material>Paper</material>\n";
                    xml += "\t\t<color>" + ((CirclePaper)k).Color.ToString() + "</color>\n";
                    xml += "\t\t<diameter>" + ((CirclePaper)k).Diameter + "</diameter>\n";
                    xml += "\t</figure>\n";
                }
                else if (k is SquarePaper)
                {
                    xml += "\t<figure type=\"Square\">\n";
                    xml += "\t\t<material>Paper</material>\n";
                    xml += "\t\t<color>" + ((SquarePaper)k).Color.ToString() + "</color>\n";
                    xml += "\t\t<height>" + ((SquarePaper)k).A + "</height>\n";
                    xml += "\t</figure>\n";
                }
                else if (k is TrianglePaper)
                {
                    xml += "\t<figure type=\"Triangle\">\n";
                    xml += "\t\t<material>Paper</material>\n";
                    xml += "\t\t<color>" + ((TrianglePaper)k).Color.ToString() + "</color>\n";
                    xml += "\t\t<side_a>" + ((TrianglePaper)k).A + "</side_a>\n";
                    xml += "\t\t<side_b>" + ((TrianglePaper)k).B + "</side_b>\n";
                    xml += "\t\t<side_c>" + ((TrianglePaper)k).C + "</side_c>\n";
                    xml += "\t</figure>\n";
                }
            }
            sw.Write("" + xml + "\n</Box>");
            sw.Close();
        }

        /// <summary>
        /// StreamReader
        /// </summary>
        /// <returns>List of figures from XML</returns>
        public List<IFigure> Read(string input)
        {
            FigureFactory factory = new FigureFactory();
            List<IFigure> boxxml = new List<IFigure>();
            StreamReader sr = new StreamReader(input);
            string doc = sr.ReadToEnd();
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(doc);
            XmlElement xRoot = xdoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                XmlNode typefigure = xnode.Attributes.GetNamedItem("type");
                switch (typefigure.Value)
                {
                    case "Circle":
                        {
                            Material material=0;
                            Colors color=0;
                            float diameter = 1;
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "material")
                                {
                                    material = (Material)Enum.Parse(typeof(Material), $"{childnode.InnerText}");

                                }
                                if (material == Material.Paper)
                                {
                                    if (childnode.Name == "color")
                                    {
                                        color = (Colors)Enum.Parse(typeof(Colors), $"{childnode.InnerText}");
                                    }
                                }
                                if (childnode.Name == "diameter")
                                {
                                    diameter = float.Parse(childnode.InnerText);
                                }
                            }
                            IFigure figure = factory.CreateFigure(material, Form.Circle, diameter);
                            if (material == Material.Paper && color != Colors.white)
                            {
                                ((IPaper)figure).Color = color;
                            }
                            boxxml.Add(figure);
                            break;
                        }
                    case "Rectangle":
                        {
                            Material material = 0;
                            Colors color = 0;
                            float height= 1;
                            float width = 1;
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "material")
                                {
                                    material = (Material)Enum.Parse(typeof(Material), $"{childnode.InnerText}");

                                }
                                if (material == Material.Paper)
                                    {
                                        if (childnode.Name == "color")
                                        {
                                            color = (Colors)Enum.Parse(typeof(Colors), $"{childnode.InnerText}");
                                        }
                                    }
                                if (childnode.Name == "height")
                                {
                                    height = float.Parse(childnode.InnerText);
                                }
                                if (childnode.Name == "width")
                                {
                                    width = float.Parse(childnode.InnerText);
                                }
                            }
                            IFigure figure = factory.CreateFigure(material, Form.Rectangle, new float []{ height,width});
                            if (material == Material.Paper && color != Colors.white)
                            {
                                ((IPaper)figure).Color = color;
                            }
                            boxxml.Add(figure);
                            break;
                        }
                    case "Square":
                        {
                            Material material = 0;
                            Colors color = 0;
                            float height = 1;
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "material")
                                {
                                    material = (Material)Enum.Parse(typeof(Material), $"{childnode.InnerText}");

                                }
                                if (material == Material.Paper)
                                {
                                    if (childnode.Name == "color")
                                    {
                                        color = (Colors)Enum.Parse(typeof(Colors), $"{childnode.InnerText}");
                                    }
                                }
                                if (childnode.Name == "height")
                                {
                                    height = float.Parse(childnode.InnerText);
                                }
                            }
                            IFigure figure = factory.CreateFigure(material, Form.Square, new float[] { height});
                            if (material == Material.Paper && color != Colors.white)
                            {
                                ((IPaper)figure).Color = color;
                            }
                            boxxml.Add(figure);
                            break;
                        }
                    case "Triangle":
                        {
                            Material material = 0;
                            Colors color = 0;
                            float a = 1;
                            float b = 1;
                            float c = 1;
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "material")
                                {
                                    material = (Material)Enum.Parse(typeof(Material), $"{childnode.InnerText}");

                                }
                                if (material == Material.Paper)
                                {
                                    if (childnode.Name == "color")
                                    {
                                        color = (Colors)Enum.Parse(typeof(Colors), $"{childnode.InnerText}");
                                    }
                                }
                                if (childnode.Name == "side_a")
                                {
                                    a = float.Parse(childnode.InnerText);
                                }
                                if (childnode.Name == "side_b")
                                {
                                    b = float.Parse(childnode.InnerText);
                                }
                                if (childnode.Name == "side_c")
                                {
                                    c = float.Parse(childnode.InnerText);
                                }
                            }
                            IFigure figure = factory.CreateFigure(material, Form.Square, new float[] { a,b,c });
                            if (material == Material.Paper && color != Colors.white)
                            {
                                ((IPaper)figure).Color = color;
                            }
                            boxxml.Add(figure);
                            break;
                        }
                }
            }
            sr.Close();
            return boxxml;
        }
    }
    /// <summary>
    /// XmlWriter and XMLReader
    /// </summary>
    public class Type2Xml
    {
        /// <summary>
        /// Method Write
        /// </summary>
        /// <param name="intoBox">Input List</param>
        public void Write(string output, List<IFigure> intoBox)
        {
            XmlWriter xmlWriter = XmlWriter.Create(output);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Boxs");
            foreach (var i in intoBox)
            {
                switch (i.GetType().Name)
                {
                    case "CircleFilm":
                        {
                            CircleFilm c1 = (CircleFilm)i;
                            xmlWriter.WriteStartElement("figure");
                            xmlWriter.WriteAttributeString("type", "Circle");
                            xmlWriter.WriteStartElement("material");
                            xmlWriter.WriteString("Film");
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("color");
                            xmlWriter.WriteString("None");
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("diameter");
                            xmlWriter.WriteString("" + c1.Diameter);
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteEndElement();
                            break;
                        }
                    case "RectangleFilm":
                        {
                            RectangleFilm r1 = (RectangleFilm)i;
                            xmlWriter.WriteStartElement("figure");
                            xmlWriter.WriteAttributeString("type", "Rectangle");
                            xmlWriter.WriteStartElement("material");
                            xmlWriter.WriteString("Film");
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("color");
                            xmlWriter.WriteString("None");
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("height");
                            xmlWriter.WriteString("" + r1.Height);
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("width");
                            xmlWriter.WriteString("" + r1.Width);
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteEndElement();
                            break;
                        }
                    case "SquareFilm":
                        {
                            SquareFilm s1 = (SquareFilm)i;
                            xmlWriter.WriteStartElement("figure");
                            xmlWriter.WriteAttributeString("type", "Square");
                            xmlWriter.WriteStartElement("material");
                            xmlWriter.WriteString("Film");
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("color");
                            xmlWriter.WriteString("None");
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("height");
                            xmlWriter.WriteString("" + s1.A);
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteEndElement();
                            break;
                        }
                    case "TriangleFilm":
                        {
                            TriangleFilm t1 = (TriangleFilm)i;
                            xmlWriter.WriteStartElement("figure");
                            xmlWriter.WriteAttributeString("type", "Triangle");
                            xmlWriter.WriteStartElement("material");
                            xmlWriter.WriteString("Film");
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("color");
                            xmlWriter.WriteString("None");
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("side_a");
                            xmlWriter.WriteString("" + t1.A);
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("side_b");
                            xmlWriter.WriteString("" + t1.B);
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteStartElement("side_c");
                            xmlWriter.WriteString("" + t1.C);
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteEndElement();
                            break;
                        }
                        case "CirclePaper":
                            {
                                CirclePaper c1 = (CirclePaper)i;
                                xmlWriter.WriteStartElement("figure");
                                xmlWriter.WriteAttributeString("type", "Circle");
                                xmlWriter.WriteStartElement("material");
                                xmlWriter.WriteString("Paper");
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteStartElement("color");
                                xmlWriter.WriteString(""+c1.Color);
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteStartElement("diameter");
                                xmlWriter.WriteString("" + c1.Diameter);
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteEndElement();
                                break;
                            }
                        case "RectanglePaper":
                            {
                                RectanglePaper r1 = (RectanglePaper)i;
                                xmlWriter.WriteStartElement("figure");
                                xmlWriter.WriteAttributeString("type", "Rectangle");
                                xmlWriter.WriteStartElement("material");
                                xmlWriter.WriteString("Paper");
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteStartElement("color");
                                xmlWriter.WriteString(""+r1.Color);
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteStartElement("height");
                                xmlWriter.WriteString("" + r1.Height);
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteStartElement("width");
                                xmlWriter.WriteString("" + r1.Width);
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteEndElement();
                                break;
                            }
                        case "SquarePaper":
                            {
                                SquarePaper s1 = (SquarePaper)i;
                                xmlWriter.WriteStartElement("figure");
                                xmlWriter.WriteAttributeString("type", "Square");
                                xmlWriter.WriteStartElement("material");
                                xmlWriter.WriteString("Paper");
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteStartElement("color");
                                xmlWriter.WriteString(""+s1.Color);
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteStartElement("height");
                                xmlWriter.WriteString("" + s1.A);
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteEndElement();
                                break;
                            }
                        case "TrianglePaper":
                            {
                                TrianglePaper t1 = (TrianglePaper)i;
                                xmlWriter.WriteStartElement("figure");
                                xmlWriter.WriteAttributeString("type", "Triangle");
                                xmlWriter.WriteStartElement("material");
                                xmlWriter.WriteString("Paper");
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteStartElement("color");
                                xmlWriter.WriteString(""+t1.Color);
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteStartElement("side_a");
                                xmlWriter.WriteString("" + t1.A);
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteStartElement("side_b");
                                xmlWriter.WriteString("" + t1.B);
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteStartElement("side_c");
                                xmlWriter.WriteString("" + t1.C);
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteEndElement();
                                break;
                            }
                    }
            }
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
        /// <summary>
        /// Method Read
        /// </summary>
        /// <returns>New List</returns>
        public List<IFigure> Read(string input)
        {
            List<IFigure> boxxml = new List<IFigure>();
            XmlReader xreader = XmlReader.Create(input);
            Material material;
            Colors color=0;
            FigureFactory factory = new FigureFactory();
            while (xreader.Read())
            {

                if (xreader.Name == "figure")
                {
                    switch (xreader.GetAttribute("type"))
                    {
                        case "Circle":
                            {
                                float d;
                                xreader.Read();
                                xreader.Read();
                                if (xreader.Name == "material")
                                {
                                    material = (Material)Enum.Parse(typeof(Material), xreader.ReadInnerXml());
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "color")
                                {
                                    if (material == Material.Paper)
                                    {
                                        color = (Colors)Enum.Parse(typeof(Colors), xreader.ReadInnerXml());
                                        xreader.Read();
                                    }
                                    else
                                    {
                                        xreader.ReadInnerXml();
                                        xreader.Read();
                                    }
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "diameter")
                                {
                                    d = float.Parse(xreader.ReadInnerXml());
                                }
                                else throw new Exception("Wrong input xml");
                                IFigure figure = factory.CreateFigure(material, Form.Circle, new float[] { d });
                                if (material == Material.Paper && color != Colors.white)
                                {
                                    ((IPaper)figure).Color = color;
                                }
                                boxxml.Add(figure);
                                break;
                            }
                        case "Square":
                            {
                                float a;
                                xreader.Read();
                                xreader.Read();
                                if (xreader.Name == "material")
                                {
                                    material = (Material)Enum.Parse(typeof(Material), xreader.ReadInnerXml());
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "color")
                                {
                                    if (material == Material.Paper)
                                    {
                                        color = (Colors)Enum.Parse(typeof(Colors), xreader.ReadInnerXml());
                                        xreader.Read();
                                    }
                                    else
                                    {
                                        xreader.ReadInnerXml();
                                        xreader.Read();
                                    }
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "height")
                                {
                                    a = float.Parse(xreader.ReadInnerXml());
                                }
                                else throw new Exception("Wrong input xml");
                                IFigure figure = factory.CreateFigure(material, Form.Square, new float[] { a });
                                if (material == Material.Paper && color != Colors.white)
                                {
                                    ((IPaper)figure).Color = color;
                                }
                                boxxml.Add(figure);
                                break;
                            }
                        case "Rectangle":
                            {
                                float h, w;
                                xreader.Read();
                                xreader.Read();
                                if (xreader.Name == "material")
                                {
                                    material = (Material)Enum.Parse(typeof(Material), xreader.ReadInnerXml());
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "color")
                                    {
                                    if (material == Material.Paper)
                                    {
                                        color = (Colors)Enum.Parse(typeof(Colors), xreader.ReadInnerXml());
                                        xreader.Read();
                                    }
                                    else
                                    {
                                        xreader.ReadInnerXml();
                                        xreader.Read();
                                    }
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "height")
                                {
                                    h = float.Parse(xreader.ReadInnerXml());
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "width")
                                {
                                    w = float.Parse(xreader.ReadInnerXml());
                                }
                                else throw new Exception("Wrong input xml");
                                IFigure figure = factory.CreateFigure(material, Form.Rectangle, new float[] { h,w });
                                if (material == Material.Paper && color != Colors.white)
                                {
                                    ((IPaper)figure).Color = color;
                                }
                                boxxml.Add(figure);
                                break;
                            }
                        case "Triangle":
                            {
                                float a, b, c;
                                xreader.Read();
                                xreader.Read();
                                if (xreader.Name == "material")
                                {
                                    material = (Material)Enum.Parse(typeof(Material), xreader.ReadInnerXml());
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "color")
                                {
                                    if (material == Material.Paper)
                                    {
                                        color = (Colors)Enum.Parse(typeof(Colors), xreader.ReadInnerXml());
                                        xreader.Read();
                                    }
                                    else
                                    {
                                        xreader.ReadInnerXml();
                                        xreader.Read();
                                    }
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "side_a")
                                {
                                    a = float.Parse(xreader.ReadInnerXml());
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "side_b")
                                {
                                    b = float.Parse(xreader.ReadInnerXml());
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "side_c")
                                {
                                    c = float.Parse(xreader.ReadInnerXml());
                                }
                                else throw new Exception("Wrong input xml");
                                IFigure figure = factory.CreateFigure(material, Form.Triangle, new float[] { a,b,c });
                                if (material == Material.Paper && color != Colors.white)
                                {
                                    ((IPaper)figure).Color = color;
                                }
                                boxxml.Add(figure);
                                break;
                            }
                    }
                }
            }
            xreader.Close();
            return boxxml;
        }
    }
}