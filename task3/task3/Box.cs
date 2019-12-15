using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class Box
    {
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
        public void ViewFigure(int i)
        {
            if ((boxoffigure.Count != 0) && (i < boxoffigure.Count))
            {
                    boxoffigure[i].ToString();
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
   /*     public int FindFigure(Figure f1)
        {
            foreach (var i in boxoffigure)
            {
                if (i.Equals(f1))
                {
                    return 
                }
            }
            return i;
        }
        //фигур в списке
        public int CountFigures()
        {
            int i = 0;//переделать
            return i;
        }
        /// <summary>
        /// Общая площадь
        /// </summary>
        /// <returns></returns>
        public float TotalArea()
        {
            float i = 0;//переделать
            return i;
        }
        /// <summary>
        /// Общий периметр
        /// </summary>
        /// <returns></returns>
        public float TotalPerimeter()
        {
            float i = 0;//переделать
            return i;
        }
        /// <summary>
        /// Удалить круги
        /// </summary>
        public void RemoveCircles()
        {

        }
        /// <summary>
        /// Удалить пленки
        /// </summary>
        public void RemovePolyethylene()
        {

        }
        /// <summary>
        /// Save xml (streamwriter)
        /// </summary>
        public void SaveXML()
        {

        }
        /// <summary>
        /// load xml (streamreader)
        /// </summary>
        public void LoadXML()
        {

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

        }*/
    }
}
