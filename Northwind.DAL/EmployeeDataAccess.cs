using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.Pocos;
using Northwind.Contracts;
namespace Northwind.DAL
{
    /// <summary>
    /// The EmployeeDataAccess class contains crud methods
    /// that manipulateS the Employees in the Northwind Database
    /// </summary>
    public class EmployeeDataAccess : IEmployee
    {
        public int InsertEmployee(InsertEmployeeDM employee)
        {
            int rowsAffected = 0;

            using (Northwind northwindContext = new Northwind())
            {
                Employee entity = new Employee();

                entity.LastName = employee.LastName;
                entity.FirstName = employee.FirstName;
                entity.Title = employee.Title;
                entity.HomePhone = employee.HomePhone;
                entity.HireDate = employee.HireDate;

                northwindContext.Employees.Add(entity);

                rowsAffected = northwindContext.SaveChanges();

            }

            return rowsAffected;

        }

        /// <summary>
        /// SelectAllEmployees executes a stored procedure named SelectAllEmployees
        /// the employees table for column info refer to 
        /// SelectAllEmployeesDM Documentation
        /// </summary>
        /// <returns>List of type SelectAllEmployeesDM objects</returns>
        public List<SelectAllEmployeesDM> SelectAllEmployees()
        {
            // create a return object
            List<SelectAllEmployeesDM> employees = new List<SelectAllEmployeesDM>();

            //establish a connection to the Northwind DB
            using (Northwind northwindContext = new Northwind())
            {

                employees = (from x in northwindContext.Employees
                             select new SelectAllEmployeesDM
                             {
                                  EmployeeID = x.EmployeeID,
                                  LastName = x.LastName,
                                  FirstName = x.FirstName,
                                  Title = x.Title,
                                  HomePhone = x.HomePhone,
                                  HireDate = x.HireDate

                             }).ToList();
                

            }//close the connection for you

            //return the data
            return employees;
        }
    }
}