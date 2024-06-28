using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPriceLibrary
{
    /// <summary>
    /// Прямоугольная форма.
    /// </summary>
    public class Rectangular : IShape
    {
        /// <summary>
        /// Прямоугольная форма.
        /// </summary>
        /// <param name="side1">Сторона 1, м</param>
        /// <param name="side2">Сторона 2, м</param>
        public Rectangular(double side1, double side2)
        {
            if (side1 > 0 && side2 > 0)
            {
                this.side1 = side1;
                this.side2 = side2;
            }
        }

        public string Name => "Прямоугольный";

        public double Square => side1 * side2;

        double side1;
        double side2;
    }
}
