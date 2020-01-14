using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Paper
{
    /// <summary>
    /// Interface for all Paper figures
    /// </summary>
    public interface IPaper
    {
        /// <summary>
        /// Property of Color
        /// </summary>
    Colors Color { get; set; }
        /// <summary>
        /// Checks only once painting a figure
        /// </summary>
        bool IsPainted { get; set; }
    }
}
