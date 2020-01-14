using Figures.BaseFigures;
using System;

namespace Figures.Film
{
    public class SquareFilm : Square, IFilm
    {
        public SquareFilm(float d) : base(d)
        {

        }
        public SquareFilm(IFigure figure, float d) : base(figure, d)
        {
            if (!(figure is IFilm))
            {
                throw new Exception("Invalid Figure's material for cut");
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is SquareFilm)
            {
                if (this.A== ((SquareFilm)obj).A)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public override int GetHashCode()
        {
            int hash = (int)((Area - A) + (A + Perimeter));
            return hash;
        }

        public override string ToString()
        {
            string txt = "Type of Figure: Square";
            txt += "\nMaterial of Figure: Film";
            txt += "\nArea of Figure:" + Area;
            txt += "\nPerimeter of Figure:" + Perimeter;
            return txt;
        }
    }
}
