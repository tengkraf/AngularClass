using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Pocos;
using System.Data.SqlClient;
namespace Northwind.DAL
{
    public partial class Northwind
    {
        //extension methods that will call stored prcedures

        public virtual List<SelectAllEmployeesDM> SelectAllEmployees()
        {
            List<SelectAllEmployeesDM> employees = 
                this.Database.SqlQuery<SelectAllEmployeesDM>("SelectAllEmployeesProc").ToList();

            return employees;
        }

        public virtual List<SelectAllCategoriesDM> SelectAllCategories()
        {
            List<SelectAllCategoriesDM> categories =
                this.Database.SqlQuery<SelectAllCategoriesDM>("SelectAllCategoriesProc").ToList();

            return categories;
        }


        public virtual List<SelectProductsByCategoryIDDM> SelectProductsByCategoryID(int categoryID)
        {
            //sqlparameter
            SqlParameter param = new SqlParameter("@CategoryID", categoryID);

            List<SelectProductsByCategoryIDDM> products =
                this.Database.SqlQuery<SelectProductsByCategoryIDDM>("SelectProductsByCategoryIDProc @CategoryID",param).ToList();

            return products;
        }


        public virtual List<SelectAllCustomersDM> SelectAllCustomers()
        {
            List<SelectAllCustomersDM> customers = 
                this.Database.SqlQuery<SelectAllCustomersDM>("SelectAllCustomersProc").ToList();

            return customers;
        }

        public virtual SelectProductByIDDM SelectProductByID(int productID)
        {
            SqlParameter productIDParam = new SqlParameter("@ProductID", productID);

            SelectProductByIDDM product = 
                        this.Database.SqlQuery<SelectProductByIDDM>("SelectProductByIDProc @ProductID", productIDParam).SingleOrDefault();

            return product;
        }
    /*
       public virtual int InsertEmployee(InsertEmployeeDM employee)
       {
            SqlParameter lastNameParam = new SqlParameter("@LastName", employee.LastName);
            SqlParameter firstNameParam = new SqlParameter("@FirstName", employee.FirstName);
            SqlParameter titleParam = new SqlParameter("@Title", employee.Title);
            SqlParameter homePhoneParam = new SqlParameter("@HomePhone", employee.HomePhone);
            SqlParameter hireDateParam = new SqlParameter("@HireDate", employee.HireDate);


            int rowsAffected = this.Database.ExecuteSqlCommand("InsertEmployeeProc @LastName,@FirstName,@Title,@HomePhone,@HireDate",
                                                                                    lastNameParam, firstNameParam, titleParam, homePhoneParam, hireDateParam);
            return rowsAffected;
        }
        */
    }
}
