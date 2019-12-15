using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    /// <summary>
    /// Class for operations with rectangle
    /// </summary>
    public class Rectangle : Figure
    {
        float width, height;
        /// <summary>
        /// Constructor for Rectangle. Uses base class constructor.
        /// </summary>
        /// <param name="m">Material</param>
        /// <param name="c">Color</param>
        /// <param name="h">Height</param>
        /// <param name="w">Width</param>
        public Rectangle(string m, string c, float h, float w):base (m,c)
        {
            width = w;
            height = h;
        }
        /// <summary>
        /// Area of Rectangle
        /// </summary>
        public override float Area { get => width * height; }
        /// <summary>
        /// Perimeter of Rectangle
        /// </summary>
        public override float Perimeter { get => 2 * (width + height); }
        /// <summary>
        /// Compares this rectangle with another object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Rectangle)
            {
                if ((this.height == ((Rectangle)obj).height)&& (this.width == ((Rectangle)obj).width))
                {
                    if ((this.Color == ((Rectangle)obj).Color))
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;           
        }/*

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        */
        /// <summary>
        /// Convert figure into string
        /// </summary>
        /// <returns>String with params</returns>
        public override string ToString()
        {
            string txt="";
            txt += Color;
            return txt;
        }
    }
 /*   class Square : Figure
    {
        float a;
        public Square(string m, string c, float a):base (m,c)
        {
            this.a = a;
        }
        public override float Area { get => a*a; }
        public override float Perimeter { get => 4 * a; }
    }
    class Triangle : Figure
    {
        float a, b, d;
        public Triangle(string m, string c, float a, float b, float d):base (m,c)
        {
            this.a = a;
            this.b = b;
            this.d = d;
        }
        public override float Area
        {
            get
            {
                float halfperimeter = Perimeter / 2;
                return (float)Math.Sqrt(halfperimeter * (halfperimeter - a) * (halfperimeter - b) * (halfperimeter - d));
            }
        }
        public override float Perimeter { get => a + b + d; }
    }
    class Circle : Figure
    {
        float diameter;
        public Circle(string m, string c, float d) : base(m,c)
        {
            diameter = d;
        }
        public override float Area { get => (float)(Math.Pow(diameter, 2) * Math.PI) / 4; }
        public override float Perimeter { get => (float)(Math.PI * diameter); }
    }*/
}
