﻿using System;

namespace Figures.BaseFigures
{
    abstract class Circle : IFigure
    {
        /// <summary>
        /// Diameter of circle
        /// </summary>
        float diameter;
        /// <summary>
        /// Constructor for Circle
        /// </summary>
        /// <param name="d">Diameter</param>
        public Circle(float d)
        {
            if (d <= 0)
            {
                throw new Exception("Invalid input parameter");
            }
            Diameter = d;
        }
        /// <summary>
        /// Constructor for cutting new circle from circle
        /// </summary>
        /// <param name="figure">Circle for cut</param>
        /// <param name="d">Diameter</param>
        public Circle(IFigure figure, float d)
        {
            if (d <= 0)
            {
                throw new Exception("Invalid input parameter");
            }
            if (!(figure is Circle))
            {
                throw new Exception("Invalid Figure for cut");
            }
            this.diameter = d;
            if (figure.Area <= this.Area)
            {
                throw new Exception("Figure fot cut less than new");
            }
        }
        /// <summary>
        /// Calculates are of circle
        /// </summary>
        public float Area
        {
            get
            {
                double i = Diameter * Diameter;
                i = i * Math.PI;
                i /= 4;
                return (float)i;
            }
        }
        /// <summary>
        /// Calculates Perimeter of circle
        /// </summary>
        public float Perimeter { get => (float)(Math.PI * Diameter); }
        /// <summary>
        /// Property of Diameter
        /// </summary>
        public float Diameter { get => diameter; set => diameter = value; }
        public abstract override bool Equals(Object obj);
        public abstract override int GetHashCode();
        public abstract override string ToString();

    }
}
