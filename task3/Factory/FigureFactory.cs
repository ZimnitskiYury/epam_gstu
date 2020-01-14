using Figures;
using Figures.Film;
using Figures.Paper;
using System;

namespace Factory
{
    /// <summary>
    /// Class of Factory nethod for creating new figure
    /// </summary>
    public class FigureFactory
    {
        /// <summary>
        /// Create new figure 
        /// </summary>
        /// <param name="material">Material of new figure</param>
        /// <param name="form">Form of new figure</param>
        /// <param name="ps">Array of other params</param>
        /// <returns>Figure</returns>
        public IFigure CreateFigure(Material material, Form form, params float [] ps)
        {
            IFigure figure;
            switch (material)
            {
                case Material.Film:
                    {
                        switch (form)
                        {
                            case Form.Circle:
                                {
                                    if (ps.Length == 1)
                                    {
                                        figure = new CircleFilm(ps[0]);
                                        break;
                                    }
                                    else throw new Exception("Wrong input parameters");                                  
                                }
                            case Form.Rectangle:
                                {
                                    if (ps.Length == 2)
                                    {
                                        figure = new RectangleFilm(ps[0], ps[1]);
                                        break;
                                    }
                                    else throw new Exception("Wrong input parameters");
                                }
                            case Form.Square:
                                {
                                    if (ps.Length == 1)
                                    {
                                        figure = new SquareFilm(ps[0]);
                                        break;
                                    }
                                    else throw new Exception("Wrong input parameters");
                                }
                            case Form.Triangle:
                                {
                                    if (ps.Length == 3)
                                    {
                                        figure = new TriangleFilm(ps[0], ps[1],ps[2]);
                                        break;
                                    }
                                    else throw new Exception("Wrong input parameters");
                                }
                            default: throw new Exception("Wrong input Form");
                        }
                        break;
                    }
                case Material.Paper:
                    {
                        switch (form)
                        {
                            case Form.Circle:
                                {
                                    if (ps.Length == 1)
                                    {
                                        figure = new CirclePaper(ps[0]);
                                        break;
                                    }
                                    else throw new Exception("Wrong input parameters");
                                }
                            case Form.Rectangle:
                                {
                                    if (ps.Length == 2)
                                    {
                                        figure = new RectanglePaper(ps[0], ps[1]);
                                        break;
                                    }
                                    else throw new Exception("Wrong input parameters");
                                }
                            case Form.Square:
                                {
                                    if (ps.Length == 1)
                                    {
                                        figure = new SquarePaper(ps[0]);
                                        break;
                                    }
                                    else throw new Exception("Wrong input parameters");
                                }
                            case Form.Triangle:
                                {
                                    if (ps.Length == 3)
                                    {
                                        figure = new TrianglePaper(ps[0], ps[1], ps[2]);
                                        break;
                                    }
                                    else throw new Exception("Wrong input parameters");
                                }
                            default: throw new Exception("Wrong input Form");
                        }
                        break;
                    }
                default: throw new Exception("Wrong input Material");
            }
            return figure;
        }
    }
}
