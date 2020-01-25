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
                                xmlWriter.WriteString("" + c1.Color);
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
                                xmlWriter.WriteString("" + r1.Color);
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
                                xmlWriter.WriteString("" + s1.Color);
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
                                xmlWriter.WriteString("" + t1.Color);
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
                Colors color = 0;
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
                                    IFigure figure = factory.CreateFigure(material, Form.Rectangle, new float[] { h, w });
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
                                    IFigure figure = factory.CreateFigure(material, Form.Triangle, new float[] { a, b, c });
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
