using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    /// <summary>
    /// Abstract class for all figures
    /// </summary>
    public abstract class Figure : IFigure
    {
        private int material;
        private int color;
        private bool isPainted = false;
        /// <summary>
        /// Enumeration of colors
        /// </summary>
        public enum Colors
        {
            red,
            blue,
            white,
            green,
            black,
            yellow,
            purple,
            pink
        }
        public enum Materials
        {
            paper,
            film
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public Figure(string m, string c)
        {
            material = m;
            color = c;
        }
        /// <summary>
        /// Area of Figure
        /// </summary>
        public abstract float Area { get; }
        /// <summary>
        /// Perimeter of Figure
        /// </summary>
        public abstract float Perimeter { get;}
        /// <summary>
        /// 
        /// </summary>
        Colors Color
        {
            get => (Colors)color;
            set
            {
                if (!isPainted)
                {
                    color = (int)value;
                }
                else 
                {
                    //Exception.FigureIsAlreadyPainted
                }
            }
        }
        Materials Material
        {
            get => (Materials)material;
            set => material = (int)value;
        }
    }
}