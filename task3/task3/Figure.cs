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
        //цвета
        public enum Colors
        {
            transparent,
            white,
            red,
            orange,
            yellow,
            green,
            blue,
            purple,
            black
        }
        public enum Materials
        {
            paper,
            polyetylene
        }

        private Colors color;
        private Materials material;
        /// <summary>
        /// 
        /// </summary>
        public Colors Color
        {
            get => color;
            set{
                if ((material == Materials.paper)&&(color==Colors.white))
                {
                    color = value;
                }
                else
                {
                    color = Colors.transparent;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Materials Material { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public abstract float Area { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public abstract float Perimeter { get; set; }
    }
}
