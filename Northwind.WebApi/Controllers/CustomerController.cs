using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Northwind.Pocos;
using Northwind.Contracts;
using Northwind.BLL;
namespace Northwind.WebApi.Controllers
{
    public class CustomerController : ApiController , ICustomer
    {
        private CustomerBusinessLogic bll = new CustomerBusinessLogic();

        [HttpGet]
        [Route("Customer/SelectAllCustomers")]
        public List<SelectAllCustomersDM> SelectAllCustomers()
        {
            List<SelectAllCustomersDM> customers = bll.SelectAllCustomers();

            return customers;
        }
    }
}
