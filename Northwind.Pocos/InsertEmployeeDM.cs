using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Pocos
{
    /// <summary>
    /// The InsertEmployeeDM class is mapped to a stored prcedure 
    /// named InsertEmployeeProc
    /// </summary>
    public class InsertEmployeeDM
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string HomePhone { get; set; }
        public DateTime? HireDate { get; set; }

    }
}