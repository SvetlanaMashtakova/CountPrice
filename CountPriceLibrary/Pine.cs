using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPriceLibrary
{
    /// <summary>
    /// Материал из сосны.
    /// </summary>
    public class Pine : IMaterial
    {
        public string Name => "Сосна";

        public int Price => 7000;
    }
}
