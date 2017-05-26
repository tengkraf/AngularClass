using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.Pocos;
namespace Northwind.Contracts
{
    public interface ICustomer
    {
        List<SelectAllCustomersDM> SelectAllCustomers();
    }
}