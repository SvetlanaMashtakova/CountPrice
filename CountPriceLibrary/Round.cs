using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPriceLibrary
{
    /// <summary>
    /// Форма окружности.
    /// </summary>
    public class Round : IShape
    {
        /// <summary>
        /// Форма окружности.
        /// </summary>
        /// <param name="radius">Радиус окружности, м</param>
        public Round(double radius)
        {
            if (radius > 0)
                this.radius = radius;
        }
        public string Name => "Круглый";
        public double Square => Math.PI * Math.Pow(radius, 2);

        double radius;
    }
}
