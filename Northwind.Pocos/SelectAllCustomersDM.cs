using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Pocos
{
    /// <summary>
    /// The SelectAllCustomersDM class maps to a stored Proc
    /// named SelectAllCustomersProc
    /// </summary>
    public class SelectAllCustomersDM
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        
    }
}