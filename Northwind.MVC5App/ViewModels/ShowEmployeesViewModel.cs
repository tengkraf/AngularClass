using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.MVC5App.ViewModels
{
    public class ShowEmployeesViewModel
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string HomePhone { get; set; }
        public DateTime HireDate { get; set; }

        //formatting property
        public string ShortHireDate
        {

            get
            {
                return HireDate.ToShortDateString();
            }
        }


    }
}
