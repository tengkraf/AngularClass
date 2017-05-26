using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.DAL;
using Northwind.Pocos;
using Northwind.Contracts;
namespace Northwind.BLL
{
    public class EmployeeBusinessLogic : IEmployee
    {
        private EmployeeDataAccess dal = new EmployeeDataAccess();

        public int InsertEmployee(InsertEmployeeDM employee)
        {
            //do work here if needed 
            int rowsAffected = dal.InsertEmployee(employee);

            return rowsAffected;
        }

        public List<SelectAllEmployeesDM> SelectAllEmployees()
        {
            //intercept the data returned from the dal and store it in a local object
            List<SelectAllEmployeesDM> employees = dal.SelectAllEmployees();

            //do a null check
            if(employees == null)
            {
                employees = new List<SelectAllEmployeesDM>();
            }

            //apply any business rules if needed


            //return the data to the webapi
            return employees;
        }
    }
}