using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    //цвета
    enum Colors
    {
        red,
        orange,
        yellow,
        green,
        blue,
        purple,
        black
    }
    enum Materials
    {
        paper,
        polyetylene
    }
    public class Figure : IFigure
    {
        Colors color;
        Materials material;

        public float Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Perimeter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
