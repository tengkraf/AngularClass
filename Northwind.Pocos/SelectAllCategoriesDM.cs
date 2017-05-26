using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Pocos
{
    /// <summary>
    /// The SelectAllCategoriesDM class is mapped to a stored prcedure 
    /// named SelectAllCategoriesProc
    /// </summary>
    public class SelectAllCategoriesDM
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}