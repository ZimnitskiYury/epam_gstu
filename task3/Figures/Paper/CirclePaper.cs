using Figures.BaseFigures;
using System;

namespace Figures.Paper
{
    public class CirclePaper : Circle, IPaper
    {
        private Colors color;
        private bool isPainted = false;
        public CirclePaper(float d) : base(d)
        {
            color = Colors.white;
        }
        public CirclePaper(string c, float d) : base(d)
        {
            color = (Colors)int.Parse(c);
        }
        public CirclePaper(IFigure figure, float d) : base(figure, d)
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

        public bool IsPainted { get => isPainted; set => isPainted=value; }

        public override bool Equals(object obj)
        {
            if (obj is CirclePaper)
            {
                if (((CirclePaper)obj).Color == Color)
                {
                    if (Diameter == ((CirclePaper)obj).Diameter)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }
        public override int GetHashCode()
        {
            int hash = (int)((Area - Diameter) + (Diameter + Perimeter));
            return hash;
        }
        public override string ToString()
        {
            string txt = "Type of Figure: Circle";
            txt += "\nMaterial of Figure: Paper";
            txt += "\nColor of Figure: " + Color.ToString();
            txt += "\nArea of Figure:" + Area;
            txt += "\nPerimeter of Figure:" + Perimeter;
            return txt;
        }
    }
}