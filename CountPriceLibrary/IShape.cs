using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPriceLibrary
{
    /// <summary>
    /// Форма.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Название формы
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Площадь м^2.
        /// </summary>
        double Square { get; }
    }
}
