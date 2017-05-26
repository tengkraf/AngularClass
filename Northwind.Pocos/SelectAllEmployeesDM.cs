using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Pocos
{
    /// <summary>
    /// The SelectAllEmployeesDM class is mapped to a stored prcedure 
    /// named SelectAllEmployeesProc
    /// </summary>
    public class SelectAllEmployeesDM
    {

        

        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string HomePhone { get; set; }
        public DateTime? HireDate  { get; set; }



    }
}