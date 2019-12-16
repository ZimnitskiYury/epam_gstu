using System.IO;
using System.Collections.Generic;
using System.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3;

namespace task3
{
    public class StreamXML
    {
        string writePath = @"C:\Users\byrtn\Downloads\output.xml";
        /// <summary>
        /// StreamWriter
        /// </summary>
        /// <param name="i">Input string</param>
        public void Write(string i)
        {
            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n<Box>\n";
            sw.Write(xml+i+"\n</Box>");
            sw.Close();
        }
        /// <summary>
        /// StreamReader
        /// </summary>
        /// <returns>List of figures from XML</returns>
        public List<Figure> Read()
        {
            List<Figure> boxxml = new List<Figure>();
            StreamReader sr = new StreamReader(@"C:\Users\byrtn\Downloads\output2.xml");
            string doc =sr.ReadToEnd();
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
            return boxxml;
        }
    }
    public class XMLWriter
    {
        public void Write()
        {
            var xml = new XmlWriter.();

        }
    }
}    