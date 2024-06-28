using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPriceLibrary
{
    /// <summary>
    /// Товар.
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Название товара.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Цена товара.
        /// </summary>
        int Price { get; }
    }
}
