using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPriceLibrary
{
    /// <summary>
    /// Материал
    /// </summary>
    public interface IMaterial
    {
        /// <summary>
        /// Название материала.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Цена материала.
        /// </summary>
        int Price { get; }
    }
}
