using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.DAL;
using Northwind.Pocos;
using Northwind.Contracts;
namespace Northwind.BLL
{
    public class CustomerBusinessLogic : ICustomer
    {
        private CustomerDataAccess dal = new CustomerDataAccess();

        public List<SelectAllCustomersDM> SelectAllCustomers()
        {
            List<SelectAllCustomersDM> customers = dal.SelectAllCustomers();

            if(customers == null)
            {
                customers = new List<SelectAllCustomersDM>();
            }
            return customers;
        }
    }
}