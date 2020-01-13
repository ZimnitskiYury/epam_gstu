using Figures.BaseFigures;
using System;

namespace Figures.Film
{
    class RectangleFilm : Rectangle, IFilm
    {
        public RectangleFilm(float h, float w):base(h,w)
        {

        }
        public RectangleFilm(IFigure figure, float h, float w) : base(figure, h, w)
        {
            if (!(figure is IFilm))
            {
                throw new Exception("Invalid Figure's material for cut");
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is RectangleFilm)
            {
                if (this.Height == ((RectangleFilm)obj).Height&& this.Width == ((RectangleFilm)obj).Width)
                {
                    return true;
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
            txt += "\nMaterial of Figure: Film";
            txt += "\nArea of Figure:" + Area;
            txt += "\nPerimeter of Figure:" + Perimeter;
            return txt;
        }
    }
}
