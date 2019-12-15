using System.IO;
using System.Collections.Generic;
using System.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class StreamXML
    {
    static string writePath = @"D:\output.xml";
        public void Write()
        {
            string text = "";
            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            sw.Write(text);
            sw.Close();
        }
        public List<Figure> Read()
        {
            List<Figure> boxxml = new List<Figure>();
            StreamReader sr = new StreamReader(writePath);
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
                    case "Rectangle": {
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
                                if (childnode.Name == "diameter")
                                {
                                    diameter = int.Parse(childnode.InnerText);
                                }
                            }
                            Circle c1 = new Circle(material, color, diameter);
                            boxxml.Add(c1);
                            break;
                        }
                }
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // если узел - company
                    if (childnode.Name == "company")
                    {
                        Console.WriteLine($"Компания: {childnode.InnerText}");
                    }
                    // если узел age
                    if (childnode.Name == "age")
                    {
                        Console.WriteLine($"Возраст: {childnode.InnerText}");
                    }
                }
                return boxxml;
        }
    }
}
*/                    