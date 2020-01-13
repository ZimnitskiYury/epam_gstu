﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.BaseFigures
{
    abstract class Rectangle:IFigure
    {
        float width, height;
        /// <summary>
        /// Constructor for Rectangle
        /// </summary>
        /// <param name="h">Height</param>
        /// <param name="w">Width</param>
        public Rectangle(float h, float w)
        {
            Width = w;
            Height = h;
        }
        /// <summary>
        /// Area of Rectangle
        /// </summary>
        public float Area { get => Width * Height; }
        /// <summary>
        /// Perimeter of Rectangle
        /// </summary>
        public float Perimeter { get => 2 * (Width + Height); }
        /// <summary>
        /// Property of width
        /// </summary>
        public float Width { get => width; set => width = value; }
        /// <summary>
        /// Property of height
        /// </summary>
        public float Height { get => height; set => height = value; }
        public abstract override bool Equals(Object obj);
        public abstract override int GetHashCode();
        public abstract override string ToString();
    }
}
