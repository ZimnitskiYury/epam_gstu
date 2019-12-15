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
        /// <param name="obj">Input object</param>
        /// <returns>true or false</returns>
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
        }
        /// <summary>
        /// Override GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int hash = (int)((Area - width) + (height + Perimeter)) + (int)Color;
            return hash;
        }
    }
    /// <summary>
    /// Class for operations with Square
    /// </summary>
    public class Square : Figure
    {
        /// <summary>
        /// Height of Square
        /// </summary>
        private float a;
        /// <summary>
        /// Constructor for Square. Uses base class constructor.
        /// </summary>
        /// <param name="m">Material</param>
        /// <param name="c">Color</param>
        /// <param name="a">Height</param>
        public Square(string m, string c, float a):base (m,c)
        {
            this.a = a;
        }
        /// <summary>
        /// Calculates Area of square
        /// </summary>
        public override float Area { get => a*a; }
        /// <summary>
        /// Calculates Parimeter of square
        /// </summary>
        public override float Perimeter { get => 4 * a; }
        /// <summary>
        /// Compares this square with another object
        /// </summary>
        /// <param name="obj">Input object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (obj is Square)
            {
                if ((this.a == ((Square)obj).a))
                {
                    if ((this.Color == ((Square)obj).Color))
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }
        /// <summary>
        /// Override GetHashCode()
        /// </summary>
        /// <returns>Int value for hashcode</returns>
        public override int GetHashCode()
        {
            int hash = (int)((Area - a) + (a+ Perimeter)) + (int)Color;
            return hash;
        }
    }
    /// <summary>
    /// Class for operations with triangle
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Sides of triangle
        /// </summary>
        float a, b, d;
        /// <summary>
        /// Constructor for Triangle. Uses base class constructor.
        /// </summary>
        /// <param name="m">Material</param>
        /// <param name="c">Color</param>
        /// <param name="a">First side</param>
        /// <param name="b">Second side</param>
        /// <param name="d">Third side</param>
        public Triangle(string m, string c, float a, float b, float d):base (m,c)
        {
            this.a = a;
            this.b = b;
            this.d = d;
        }
        /// <summary>
        /// Calculates Area of triangle
        /// </summary>
        public override float Area
        {
            get
            {
                float halfperimeter = Perimeter / 2;
                return (float)Math.Sqrt(halfperimeter * (halfperimeter - a) * (halfperimeter - b) * (halfperimeter - d));
            }
        }
        /// <summary>
        /// Calculates Perimeter of triangle
        /// </summary>
        public override float Perimeter { get => a + b + d; }
        /// <summary>
        /// Compares Triangle with another object
        /// </summary>
        /// <param name="obj">Input object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (obj is Triangle)
            {
                if ((this.a == ((Triangle)obj).a)&& (this.b == ((Triangle)obj).b)&& (this.d == ((Triangle)obj).d))
                {
                    if ((this.Color == ((Triangle)obj).Color))
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }
        /// <summary>
        /// Override GetHashCode()
        /// </summary>
        /// <returns>Int value for hash code</returns>
        public override int GetHashCode()
        {
            int hash = (int)((Area - a) + (b + Perimeter)) + (int)Color+(int)d;
            return hash;
        }
    }
    /// <summary>
    /// Class for operations with Circle
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Diameter of circle
        /// </summary>
        float diameter;
        /// <summary>
        /// Constructor for Circle. Uses base class constructor.
        /// </summary>
        /// <param name="m">Material</param>
        /// <param name="c">Color</param>
        /// <param name="d">Diameter</param>
        public Circle(string m, string c, float d) : base(m,c)
        {
            diameter = d;
        }
        /// <summary>
        /// Calculates are of circle
        /// </summary>
        public override float Area
        {
            get
            {
                double i = diameter * diameter;
                i = i * Math.PI;
                i /= 4;
                return (float)i;
            }
        }
        /// <summary>
        /// Calculates Perimeter of circle
        /// </summary>
        public override float Perimeter { get => (float)(Math.PI * diameter); }
        /// <summary>
        /// Compares Triangle with another object
        /// </summary>
        /// <param name="obj">Input object</param>
        /// <returns>true or false</returns>
        public override bool Equals(object obj)
        {
            if (obj is Circle)
            {
                if ((this.diameter== ((Circle)obj).diameter))
                {
                    if ((this.Color == ((Circle)obj).Color))
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }
        /// <summary>
        /// Override GetHashCode()
        /// </summary>
        /// <returns>Int value for hashcode</returns>
        public override int GetHashCode()
        {
            int hash = (int)((Area - diameter) + (diameter+ Perimeter)) + (int)Color;
            return hash;
        }
    }
}
