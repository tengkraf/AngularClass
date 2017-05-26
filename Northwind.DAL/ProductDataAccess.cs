using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.Pocos;
using Northwind.Contracts;
namespace Northwind.DAL
{
    public class ProductDataAccess : IProduct
    {
        public SelectProductByIDDM SelectProductByID(int productID)
        {
            SelectProductByIDDM product = new SelectProductByIDDM();

            using (Northwind northwindContext = new Northwind())
            {
                //product = northwindContext.SelectProductByID(productID);
                product = (from table in northwindContext.Products
                           where table.ProductID == productID
                           select new SelectProductByIDDM
                           {
                                ProductID = table.ProductID,
                                ProductName = table.ProductName,
                                UnitPrice = (decimal)table.UnitPrice,
                                Discontinued = table.Discontinued

                           }).SingleOrDefault();
            }
            return product;
        }

        public int SelectProductCount()
        {
            int productCount = 0;

            using (Northwind northwindContext = new Northwind())
            {

                productCount = northwindContext.Products.Count();
            }

            return productCount;
        }

        public List<SelectProductsByCategoryIDDM> SelectProductsByCategoryID(int categoryID)
        {
            List<SelectProductsByCategoryIDDM> products = new List<SelectProductsByCategoryIDDM>();

            using (Northwind northwindContext = new Northwind())
            {
                products = northwindContext.SelectProductsByCategoryID(categoryID);
            }

           return products;
        }
    }
}