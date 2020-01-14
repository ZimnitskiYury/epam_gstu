using Figures.BaseFigures;
using System;

namespace Figures.Film
{
    /// <summary>
    /// Class for figure Circle (Film)
    /// </summary>
   public class CircleFilm : Circle, IFilm
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="d">Input diameter</param>
        public CircleFilm(float d):base(d)
        {

        }
        /// <summary>
        /// Copy constructor for cutting
        /// </summary>
        /// <param name="figure">Input figure</param>
        /// <param name="d">input diameter</param>
        public CircleFilm(IFigure figure, float d) : base(figure, d)
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
            if (obj is CircleFilm)
            {
                if (Diameter == ((CircleFilm)obj).Diameter)
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
            int hash = (int)((Area - Diameter) + (Diameter + Perimeter));
            return hash;
        }
        /// <summary>
        /// Override Object.ToString()
        /// </summary>
        /// <returns>String value</returns>
        public override string ToString()
        {
            string txt = "Type of Figure: Circle";
            txt += "\nMaterial of Figure: Film";
            txt += "\nArea of Figure:" + Area;
            txt += "\nPerimeter of Figure:" + Perimeter;
            return txt;
        }
    }
}
