﻿using Figures.BaseFigures;
using System;

namespace Figures.Film
{
    /// <summary>
    /// Class for figure Rectangle (Film)
    /// </summary>
    public class RectangleFilm : Rectangle, IFilm
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="h">Height of rectanfle</param>
        /// <param name="w">Width of rectangle</param>
        public RectangleFilm(float h, float w):base(h,w)
        {

        }
        /// <summary>
        /// Copy Constructor for cutting
        /// </summary>
        /// <param name="figure">Input Figure</param>
        /// <param name="h">Height</param>
        /// <param name="w">Width</param>
        public RectangleFilm(IFigure figure, float h, float w) : base(figure, h, w)
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
            if (obj is RectangleFilm)
            {
                if (this.Height == ((RectangleFilm)obj).Height&& this.Width == ((RectangleFilm)obj).Width)
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
            int hash = (int)((Area - Width) + (Height + Perimeter));
            return hash;
        }
        /// <summary>
        /// Override Object.ToString()
        /// </summary>
        /// <returns>String value</returns>
        public override string ToString()
        {
            string txt = "Type of Figure: Rectangle";
            txt += "\nMaterial of Figure: Film";
            txt += "\nArea of Figure:" + Area;
            txt += "\nPerimeter of Figure:" + Perimeter;
            return txt;
        }
    }
}
