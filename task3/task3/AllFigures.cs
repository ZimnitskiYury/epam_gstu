using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Rectangle : Figure
    {
        float width, height;
        public Rectangle(string m, string c, float h, float w):base (m,c)
        {
            width = w;
            height = h;
        }
        public override float Area { get => width * height; }
        public override float Perimeter { get => 2 * (width + height); }
    }
    class Square : Figure
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
    }
}
