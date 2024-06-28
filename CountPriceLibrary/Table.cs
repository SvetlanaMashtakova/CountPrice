using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPriceLibrary
{
    /// <summary>
    /// Стол
    /// </summary>
    public class Table : IProduct
    {
        /// <summary>
        /// Стол
        /// </summary>
        /// <param name="material">Материал</param>
        /// <param name="shape">Фигура</param>
        public Table(IMaterial material, IShape shape)
        {
            this.material = material;
            this.shape = shape;
        }

        public string Name { get { return "Стол"; } }
        public int Price
        {
            get
            {
                return Convert.ToInt32(material.Price * shape.Square) / 10 * 10;
            }
        }

        IMaterial material;
        IShape shape;
    }
}
