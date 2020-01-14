using Figures.BaseFigures;
using System;

namespace Figures.Paper
{
    public class TrianglePaper : Triangle, IPaper
    {
        private Colors color;
        private bool isPainted = false;
        public TrianglePaper(float a, float b, float c) : base(a, b, c)
        {
            color = Colors.white;
        }
        public TrianglePaper(string col, float a, float b, float c) : base(a, b, c)
        {
            color = (Colors)int.Parse(col);
        }
        public TrianglePaper(IFigure figure, float a, float b, float c) : base(figure, a, b, c)
        {
            if (!(figure is IPaper))
            {
                throw new Exception("Invalid Figure's material for cut");
            }
            else
            {
                IPaper cp1 = (IPaper)figure;
                Color = cp1.Color;
                IsPainted = cp1.IsPainted;
            }
        }

        public Colors Color
        {
            get => color;
            set
            {
                if (value != color)
                {
                    if (!IsPainted)
                    {
                        color = value;
                        IsPainted = true;
                    }
                    else
                    {
                        throw new Exception("Figure Is Already Painted");
                    }
                }
                else throw new Exception("Figure already " + color.ToString() + ". Select another color");
            }
        }
        public bool IsPainted { get => isPainted; set => isPainted = value; }

        public override bool Equals(object obj)
        {
            if (obj is TrianglePaper)
            {
                if (A == ((TrianglePaper)obj).A && B == ((TrianglePaper)obj).B && C == ((TrianglePaper)obj).C)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public override int GetHashCode()
        {
            int hash = (int)((Area - A) + (B + Perimeter)) + (int)C;
            return hash;
        }

        public override string ToString()
        {
            string txt = "Type of Figure: Triangle";
            txt += "\nMaterial of Figure: Paper";
            txt += "\nColor of Figure: " + Color.ToString();
            txt += "\nArea of Figure:" + Area;
            txt += "\nPerimeter of Figure:" + Perimeter;
            return txt;
        }
    }
}
