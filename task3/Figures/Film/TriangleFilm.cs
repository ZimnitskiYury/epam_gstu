using Figures.BaseFigures;
using System;

namespace Figures.Film
{
    /// <summary>
    /// Class for figure Triangle (Film)
    /// </summary>
    public class TriangleFilm : Triangle, IFilm
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="a">Input side a</param>
        /// <param name="b">Input side b</param>
        /// <param name="c">Input side c</param>
        public TriangleFilm(float a, float b, float c) : base(a, b, c)
        {

        }
        /// <summary>
        /// Copy Constructor for cutting
        /// </summary>
        /// <param name="figure">Input figure</param>
        /// <param name="a">Input side a</param>
        /// <param name="b">Input side b</param>
        /// <param name="c">Input side c</param>
        public TriangleFilm(IFigure figure, float a, float b, float c) : base(figure, a, b, c)
        {
            if (!(figure is IFilm))
            {
                throw new Exception("Invalid Figure's material for cut");
            }
        }
        /// <summary>
        /// Override Object.Equals()
        /// </summary>
        /// <param name="obj">Input object</param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            if (obj is TriangleFilm)
            {
                if (A == ((TriangleFilm)obj).A && B == ((TriangleFilm)obj).B && C == ((TriangleFilm)obj).C)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
        /// <summary>
        /// Override Object.GetHashCode()
        /// </summary>
        /// <returns>Int value</returns>
        public override int GetHashCode()
        {
            int hash = (int)((Area - A) + (B + Perimeter)) + (int)C;
            return hash;
        }
        /// <summary>
        /// Override Object.ToString()
        /// </summary>
        /// <returns>String value</returns>
        public override string ToString()
        {
            string txt = "Type of Figure: Triangle";
            txt += "\nMaterial of Figure: Film";
            txt += "\nArea of Figure:" + Area;
            txt += "\nPerimeter of Figure:" + Perimeter;
            return txt;
        }
    }
}
