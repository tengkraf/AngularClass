using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Pocos
{
    /// <summary>
    /// The SelectProductByIDDM class is mapped to a stored prcedure 
    /// named SelectProductByIDProc
    /// </summary>
    public class SelectProductByIDDM
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
        public decimal  UnitPrice { get; set; }
        /// <summary>
        /// bool read write
        /// </summary>
        public bool Discontinued { get; set; }
    }
}