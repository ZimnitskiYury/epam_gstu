using System;
using System.Collections.Generic;
using System.IO;
using Figures;
using Figures.BaseFigures;
using Figures.Film;
using Figures.Paper;

namespace Box
{
    /// <summary>
    /// Box of Figures. Max count 20.
    /// </summary>
    public class BoxofFigures
    {

        /// <summary>
        /// List of figures.
        /// </summary>
        private List<IFigure> boxoffigure;
        /// <summary>
        /// Default constructor for box of 20 figures
        /// </summary>
        public BoxofFigures()
        {
            boxoffigure = new List<IFigure>(20);
        }
        /// <summary>
        /// Constructor for individual capacity of figures
        /// </summary>
        /// <param name="c">Capacity of box</param>
        public BoxofFigures(int c)
        {
            boxoffigure = new List<IFigure>(c);
        }
        /// <summary>
        /// Add new figure into box
        /// </summary>
        /// <param name="f1">Input figure</param>
        public void AddFigure(IFigure f1)
        {
            if (boxoffigure.Count == boxoffigure.Capacity)
            {
                throw new Exception("Box is full");
            }
            else
            {
                boxoffigure.Add(f1);
            }
        }
        /// <summary>
        /// Add new figure into box
        /// </summary>
        /// <param name="f1">Input figure</param>
        /// <param name="i">Index of Figure in box</param>
        public void AddFigure(IFigure f1, int i)
        {
            if (boxoffigure.Count == boxoffigure.Capacity)
            {
                throw new Exception("Box is full");
            }
            else if (boxoffigure.Count < i)
            {
                throw new Exception("Wrong index");
            }
            else
            {
                boxoffigure.Insert(i, f1);
            }
        }
        /// <summary>
        /// View figure by index without remove
        /// </summary>
        /// <param name="i">Index of figure in box</param>
        public IFigure ViewFigure(int i)
        {
            if ((boxoffigure.Count != 0) && (i < boxoffigure.Count))
            {
                    return boxoffigure[i];
            }
            else throw new Exception("Box don't have this figure");
        }
        /// <summary>
        /// Remove Figure by index
        /// </summary>
        /// <param name="i">Index of figure in box</param>
        public void RemoveFigure(int i)
        {
            if ((boxoffigure.Count != 0)&&(i<boxoffigure.Count))
            {
                boxoffigure.RemoveAt(i);
            }
            else
            {
                throw new Exception("Box don't have this figure");
            }
        }
        /// <summary>
        /// Replace Figure on another by index
        /// </summary>
        /// <param name="f1">New Figure</param>
        /// <param name="i">Index of figure in box</param>
        public void ReplaceFigure(IFigure f1, int i)
        {
            if ((boxoffigure.Count != 0) && (i < boxoffigure.Count))
            {
                RemoveFigure(i);
                AddFigure(f1, i);
            }
            else
            {
                throw new Exception("Box dont have this index of figure");
            }
        }
        /// <summary>
        /// Find figure in box
        /// </summary>
        /// <param name="f1">Figure for search</param>
        /// <returns>Index of figure in box</returns>
        public string FindFigure(IFigure f1)
        {
            string k = null;
            for (int i = 0; i < boxoffigure.Count; i++)
            {
                if (boxoffigure[i].Equals(f1))
                {
                    return k += i;
                }
            }
            return k;
        }
        /// <summary>
        /// Count of figures in box
        /// </summary>
        /// <returns>Int value</returns>
        public int CountFigures()
        {
            return boxoffigure.Count;
        }
        /// <summary>
        /// Total area of all figures into box
        /// </summary>
        /// <returns>Float value of area</returns>
        public float TotalArea()
        {
            float totalarea=0;
            foreach (var i in boxoffigure)
            {
                totalarea += i.Area;
            }
            return totalarea;
        }
        /// <summary>
        /// Total perimeter of all figures into box
        /// </summary>
        /// <returns>Float value of perimeter</returns>
        public float TotalPerimeter()
        {
            float totalperimeter = 0;
            foreach (var i in boxoffigure)
            {
                totalperimeter += i.Perimeter;
            }
            return totalperimeter;
        }
        /// <summary>
        /// Delete all circles into box
        /// </summary>
        public void RemoveCircles()
        {
            foreach (var i in boxoffigure)
            {
                if(i is Circle)
                {
                    boxoffigure.Remove(i);
                }
            }
        }
        /// <summary>
        /// Delete all film figures
        /// </summary>
        public void RemoveFilm()
        {
            foreach (var i in boxoffigure)
            {
                if (i is IFilm)
                {
                    boxoffigure.Remove(i);
                }
            }
        }
        /// <summary>
        /// Save xml (streamwriter)
        /// </summary>
/*        public void SaveXMLAll()
        {
            FirstXml sxml = new FirstXml();
            string txt = "";
            foreach(var i in boxoffigure)
            {
                txt += i.GetXML();
            }
            sxml.Write(txt);
        }
        /// <summary>
        /// Save xml (only film)
        /// </summary>
        public void SaveXMLFilm()
        {
            Stream sxml = new Stream();
            string txt = "";
            foreach (var i in boxoffigure)
            {
                if (i.Material == "film")
                {
                    txt += i.GetXML();
                }
            }
            sxml.Write(txt);
        }
        /// <summary>
        /// Save xml (only paper)
        /// </summary>
        public void SaveXMLPaper()
        {
            Stream sxml = new Stream();
            string txt = "";
            foreach (var i in boxoffigure)
            {
                if (i.Material == "paper")
                {
                    txt += i.GetXML();
                }
            }
            sxml.Write(txt);
        }
        /// <summary>
        /// load xml (streamreader)
        /// </summary>
        public void LoadXML()
        {
            Stream sxml = new Stream();
            boxoffigure = sxml.Read();
        }
        /// <summary>
        /// Save xml (xmlwriter)
        /// </summary>
        public void SaveXML2All()
        {
            XML wx = new XML();
            wx.Write(boxoffigure);
        }
        /// <summary>
        /// Save xml only film (xmlwriter)
        /// </summary>
        public void SaveXML2Film()
        {
            XML wx = new XML();
            List<Figure> filmbox = new List<Figure>();
            foreach(var i in boxoffigure)
            {
                if (i.Material == "film")
                {
                    filmbox.Add(i);
                }
            }
            wx.Write(filmbox);
        }
        /// <summary>
        /// Save xml only paper (xmlwriter)
        /// </summary>
        public void SaveXML2Paper()
        {
            XML wx = new XML();
            List<Figure> paperbox = new List<Figure>();
            foreach (var i in boxoffigure)
            {
                if (i.Material == "paper")
                {
                    paperbox.Add(i);
                }
            }
            wx.Write(paperbox);
        }
        /// <summary>
        /// load xml (xmlreader)
        /// </summary>
        public void LoadXML2()
        {
            XML sx = new XML();
            boxoffigure = sx.Read();
        }*/
    }
}
