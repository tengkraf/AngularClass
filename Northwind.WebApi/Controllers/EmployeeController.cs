using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Northwind.Pocos;
using Northwind.Contracts;
using Northwind.BLL;
using System.Web.Http.Cors;
namespace Northwind.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeeController : ApiController, IEmployee
    {
        private EmployeeBusinessLogic bll = new EmployeeBusinessLogic();

        [HttpPost]
        [Route("Employee/InsertEmployee")]
        public int InsertEmployee(InsertEmployeeDM employee)
        {
            int rowsAffected = bll.InsertEmployee(employee);

            return rowsAffected;
        }

        [HttpGet]
        [Route("Employee/SelectAllEmployees")]
        public List<SelectAllEmployeesDM> SelectAllEmployees()
        {
            List<SelectAllEmployeesDM> employees = bll.SelectAllEmployees();

            //web api framework will convert your data to json format
            return employees;
        }
    }
}
