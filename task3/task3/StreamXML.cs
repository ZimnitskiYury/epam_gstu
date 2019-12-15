using System.IO;
using System.Collections.Generic;
using System.Xml;

namespace task3
{
    public class StreamXML
    {
    static string writePath = @"D:\output.xml";
        public void Write()
        {
            string text = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>";
            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            sw.Write(text);
            sw.Close();
        }
        public List<string> Read()
        {
            List<string> boxxml = new List<string>();
            StreamReader sr = new StreamReader(writePath);
            string doc =sr.ReadToEnd();
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(doc);
            XmlElement xRoot = xdoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
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
                    