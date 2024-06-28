using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPriceLibrary
{
    /// <summary>
    /// Материал из дуба.
    /// </summary>
    public class Oak : IMaterial
    {
        public string Name => "Дуб";

        public int Price => 12000;
    }
}
