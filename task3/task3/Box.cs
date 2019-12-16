using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    /// <summary>
    /// Box of Figures. Max count 20.
    /// </summary>
    public class Box
    {
        /// <summary>
        /// List of figures.
        /// </summary>
        List<Figure> boxoffigure = new List<Figure>(20);
        /// <summary>
        /// Add new figure into box
        /// </summary>
        /// <param name="f1">Input figure</param>
        public void AddFigure(Figure f1)
        {
            //Проверка на переполнение коробки. макс 20
            if (boxoffigure.Count == 20)
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
        public void AddFigure(Figure f1, int i)
        {
            //Проверка на переполнение коробки. макс 20
            if (boxoffigure.Count == 19)
            {
                throw new Exception("Box is full");
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
        public Figure ViewFigure(int i)
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
        public void ReplaceFigure(Figure f1, int i)
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
/*        public int FindFigure(Figure f1)
        {
            for (int i = 0; i < boxoffigure.Count; i++)
            {
                if (boxoffigure[i].Equals(f1))
                {
                    return i;
                }
            }

        }*/
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
                if (i.Material=="film")
                {
                    boxoffigure.Remove(i);
                }
            }
        }
        /// <summary>
        /// Save xml (streamwriter)
        /// </summary>
        public void SaveXML()
        {
            StreamXML sxml = new StreamXML();
            string txt = "";
            foreach(var i in boxoffigure)
            {
                txt += i.GetXML();
            }
            sxml.Write(txt);
        }
        /// <summary>
        /// load xml (streamreader)
        /// </summary>
        public void LoadXML()
        {
            StreamXML sxml = new StreamXML();
            boxoffigure = sxml.Read();
        }
        /// <summary>
        /// Save xml (xmlwriter)
        /// </summary>
        public void SaveXML2()
        {

        }
        /// <summary>
        /// load xml (xmlreader)
        /// </summary>
        public void LoadXML2()
        {

        }
    }
}
