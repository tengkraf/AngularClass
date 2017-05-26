using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.Pocos;
using Northwind.Contracts;
namespace Northwind.DAL
{
    public class CustomerDataAccess : ICustomer
    {
        public List<SelectAllCustomersDM> SelectAllCustomers()
        {
            List<SelectAllCustomersDM> customers = new List<SelectAllCustomersDM>();

            using (Northwind northwindContext = new Northwind())
            {
                customers = northwindContext.SelectAllCustomers();

            }

            return customers;
        }
    }
}