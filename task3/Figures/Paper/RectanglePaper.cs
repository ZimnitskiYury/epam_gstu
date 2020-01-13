using Figures.BaseFigures;
using System;

namespace Figures.Paper
{
    class RectanglePaper : Rectangle, IPaper
    {
        private Colors color;
        private bool isPainted = false;
        public RectanglePaper(float h, float w) : base(h, w)
        {
            color = Colors.white;
        }
        public RectanglePaper(string c, float h, float w) : base(h, w)
        {
            color = (Colors)int.Parse(c);
        }
        public RectanglePaper(IFigure figure, float h, float w) : base(figure, h, w)
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
            if (obj is RectanglePaper)
            {
                if (((RectanglePaper)obj).Color == Color)
                {
                    if (this.Height == ((RectanglePaper)obj).Height && this.Width == ((RectanglePaper)obj).Width)
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
            int hash = (int)((Area - Width) + (Height + Perimeter));
            return hash;
        }
        public override string ToString()
        {
            string txt = "Type of Figure: Rectangle";
            txt += "\nMaterial of Figure: Paper";
            txt += "\nColor of Figure: " + Color.ToString();
            txt += "\nArea of Figure:" + Area;
            txt += "\nPerimeter of Figure:" + Perimeter;
            return txt;
        }
    }
}
