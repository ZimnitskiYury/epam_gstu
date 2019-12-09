using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Figure : IFigure
    {
        private int? form;
        private int? material;
        private int? color;
        private bool isPainted = false;
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
        /// <summary>
        /// 
        /// </summary>
        public Figure(string m, string f, string c)
        {
            Material = m;
            Form = f;
            Color = c;
        }
        /// <summary>
        /// 
        /// </summary>
        public abstract float Area { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public abstract float Perimeter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        Colors Color
        {
            get => (Colors)color;
            set
            {
                if (color == null)
                {
                    color = (int)value;
                }
                else if (isPainted)
                {
                    color = (int)value;
                    isPainted = true;
                }
                else
                {
                    //Exception.FigureIsAlreadyPainted
                }
            }
        }
        string Material { get => material; set => material = value; }
        string Form { get => form; set => form = value; }
    }
}
