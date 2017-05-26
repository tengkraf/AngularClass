using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.MVC5App.ViewModels
{
    public class ProductByIDViewModel
    {
        /// <summary>
        ///  int read write
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// string read write
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        ///  decimal read write
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// bool read write
        /// </summary>
        public bool Discontinued { get; set; }


        public string FormattedPrice
        {
            get
            {
                return UnitPrice.ToString("c");
            }
        }
    }
}
