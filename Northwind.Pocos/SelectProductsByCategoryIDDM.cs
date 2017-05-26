using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Pocos
{
    /// <summary>
    /// The SelectProductsByCategoryIDDM class is mapped to a stored prcedure 
    /// named SelectProductsByCategoryIDProc
    /// </summary>
    public class SelectProductsByCategoryIDDM
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

      

    }
}