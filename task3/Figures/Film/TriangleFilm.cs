using Figures.BaseFigures;
using System;

namespace Figures.Film
{
    class TriangleFilm : Triangle, IFilm
    {
        public TriangleFilm(float a, float b, float c) : base(a, b, c)
        {

        }
        public TriangleFilm(IFigure figure, float a, float b, float c) : base(figure, a, b, c)
        {
            if (!(figure is IFilm))
            {
                throw new Exception("Invalid Figure's material for cut");
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is TriangleFilm)
            {
                if (A == ((TriangleFilm)obj).A && B == ((TriangleFilm)obj).B && C == ((TriangleFilm)obj).C)
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
            txt += "\nMaterial of Figure: Film";
            txt += "\nArea of Figure:" + Area;
            txt += "\nPerimeter of Figure:" + Perimeter;
            return txt;
        }
    }
}
