using Figures.BaseFigures;
using System;

namespace Figures.Film
{
    class CircleFilm : Circle, IFilm
    {
        public CircleFilm(float d):base(d)
        {

        }
        public CircleFilm(IFigure figure, float d) : base(figure, d)
        {
            if (!(figure is IFilm))
            {
                throw new Exception("Invalid Figure's material for cut");
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is CircleFilm)
            {
                if (Diameter == ((CircleFilm)obj).Diameter)
                {
                    return true;
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
            txt += "\nMaterial of Figure: Film";
            txt += "\nArea of Figure:" + Area;
            txt += "\nPerimeter of Figure:" + Perimeter;
            return txt;
        }
    }
}
