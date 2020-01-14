using System.IO;
using System.Collections.Generic;
using System.Xml;
using System;
using Figures;
using Figures.BaseFigures;
using Figures.Film;
using Figures.Paper;

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
                else if (k is SquareFilm)
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
            sw.Write(xml + "\n</Box>");
            sw.Close();
        }
    }
        /// <summary>
        /// StreamReader
        /// </summary>
        /// <returns>List of figures from XML</returns>
 /*       public List<IFigure> Read()
        {
            List<IFigure> boxxml = new List<IFigure>();
            StreamReader sr = new StreamReader("input.xml");
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
                            string material = "", color = "";
                            int diameter = 1;
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "material")
                                {
                                    material = $"{childnode.InnerText}";
                                }
                                if (childnode.Name == "color")
                                {
                                    color = $"{childnode.InnerText}";
                                }
                                if (childnode.Name == "diameter")
                                {
                                    diameter = int.Parse(childnode.InnerText);
                                }
                            }
                            Circle c1 = new Circle(material, color, diameter);
                            boxxml.Add(c1);
                            break;
                        }
                    case "Rectangle":
                        {
                            string material = "", color = "";
                            int height = 1;
                            int width = 1;
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "material")
                                {
                                    material = $"{childnode.InnerText}";
                                }
                                if (childnode.Name == "color")
                                {
                                    color = $"{childnode.InnerText}";
                                }
                                if (childnode.Name == "height")
                                {
                                    height = int.Parse(childnode.InnerText);
                                }
                                if (childnode.Name == "width")
                                {
                                    width = int.Parse(childnode.InnerText);
                                }
                            }
                            Rectangle c1 = new Rectangle(material, color, height, width);
                            boxxml.Add(c1);
                            break;
                        }
                    case "Square":
                        {
                            string material = "", color = "";
                            int height = 1;
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "material")
                                {
                                    material = $"{childnode.InnerText}";
                                }
                                if (childnode.Name == "color")
                                {
                                    color = $"{childnode.InnerText}";
                                }
                                if (childnode.Name == "height")
                                {
                                    height = int.Parse(childnode.InnerText);
                                }
                            }
                            Square c1 = new Square(material, color, height);
                            boxxml.Add(c1);
                            break;
                        }
                    case "Triangle":
                        {
                            string material = "", color = "";
                            int a = 1;
                            int b = 1;
                            int d = 1;
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "material")
                                {
                                    material = $"{childnode.InnerText}";
                                }
                                if (childnode.Name == "color")
                                {
                                    color = $"{childnode.InnerText}";
                                }
                                if (childnode.Name == "side_a")
                                {
                                    a = int.Parse(childnode.InnerText);
                                }
                                if (childnode.Name == "side_b")
                                {
                                    b = int.Parse(childnode.InnerText);
                                }
                                if (childnode.Name == "side_d")
                                {
                                    d = int.Parse(childnode.InnerText);
                                }
                            }
                            Triangle c1 = new Triangle(material, color, a, b, d);
                            boxxml.Add(c1);
                            break;
                        }
                }
            }
            sr.Close();
            return boxxml;
        }
    }*/
    /// <summary>
    /// XmlWriter and XMLReader
    /// </summary>
    public class Type2Xml
    {
        /// <summary>
        /// Method Write
        /// </summary>
        /// <param name="intoBox">Input List</param>
        public void Write(List<IFigure> intoBox)
        {
            XmlWriter xmlWriter = XmlWriter.Create("test.xml");
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
  /*      /// <summary>
        /// Method Read
        /// </summary>
        /// <returns>New List</returns>
        public List<Figure> Read()
        {
            List<Figure> boxxml = new List<Figure>();
            XmlReader xreader = XmlReader.Create("input.xml");
            string m;
            string c;
            while (xreader.Read())
            {

                if (xreader.Name == "figure")
                {
                    switch (xreader.GetAttribute("type"))
                    {
                        case "Circle":
                            {
                                int d;
                                xreader.Read();
                                xreader.Read();
                                if (xreader.Name == "material")
                                {
                                    m = xreader.ReadInnerXml();
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "color")
                                {
                                    c = xreader.ReadInnerXml();
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "diameter")
                                {
                                    d = Int32.Parse(xreader.ReadInnerXml());
                                }
                                else throw new Exception("Wrong input xml");
                                boxxml.Add(new Circle(m,c,d));
                                break;
                            }
                        case "Square":
                            {
                                int a;
                                xreader.Read();
                                xreader.Read();
                                if (xreader.Name == "material")
                                {
                                    m = xreader.ReadInnerXml();
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "color")
                                {
                                    c = xreader.ReadInnerXml();
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "height")
                                {
                                    a = Int32.Parse(xreader.ReadInnerXml());
                                }
                                else throw new Exception("Wrong input xml");
                                boxxml.Add(new Square(m, c, a));
                                break;
                            }
                        case "Rectangle":
                            {
                                int h, w;
                                xreader.Read();
                                xreader.Read();
                                if (xreader.Name == "material")
                                {
                                    m = xreader.ReadInnerXml();
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "color")
                                {
                                    c = xreader.ReadInnerXml();
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "height")
                                {
                                    h = Int32.Parse(xreader.ReadInnerXml());
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "width")
                                {
                                    w = Int32.Parse(xreader.ReadInnerXml());
                                }
                                else throw new Exception("Wrong input xml");
                                boxxml.Add(new Rectangle(m, c, h, w));
                                break;
                            }
                        case "Triangle":
                            {
                                int a, b, d;
                                xreader.Read();
                                xreader.Read();
                                if (xreader.Name == "material")
                                {
                                    m = xreader.ReadInnerXml();
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "color")
                                {
                                    c = xreader.ReadInnerXml();
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "a")
                                {
                                    a = Int32.Parse(xreader.ReadInnerXml());
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "b")
                                {
                                    b = Int32.Parse(xreader.ReadInnerXml());
                                    xreader.Read();
                                }
                                else throw new Exception("Wrong input xml");
                                if (xreader.Name == "d")
                                {
                                    d = Int32.Parse(xreader.ReadInnerXml());
                                }
                                else throw new Exception("Wrong input xml");
                                boxxml.Add(new Triangle(m, c, a, b, d));
                                break;
                            }
                    }
                }
            }
            xreader.Close();
            return boxxml;
        }*/
    }
}