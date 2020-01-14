using Figures.BaseFigures;
using System;

namespace Figures.Film
{
    /// <summary>
    /// Class for figure Square (Film)
    /// </summary>
    public class SquareFilm : Square, IFilm
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="d">Input height</param>
        public SquareFilm(float d) : base(d)
        {

        }
        /// <summary>
        /// Copy constructor for cutting
        /// </summary>
        /// <param name="figure">Input figure</param>
        /// <param name="d">Input height</param>
        public SquareFilm(IFigure figure, float d) : base(figure, d)
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
            if (obj is SquareFilm)
            {
                if (this.A== ((SquareFilm)obj).A)
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
            int hash = (int)((Area - A) + (A + Perimeter));
            return hash;
        }
        /// <summary>
        /// Override Object.ToString()
        /// </summary>
        /// <returns>String value</returns>
        public override string ToString()
        {
            string txt = "Type of Figure: Square";
            txt += "\nMaterial of Figure: Film";
            txt += "\nArea of Figure:" + Area;
            txt += "\nPerimeter of Figure:" + Perimeter;
            return txt;
        }
    }
}
