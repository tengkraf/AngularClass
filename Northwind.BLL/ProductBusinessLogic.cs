using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.DAL;
using Northwind.Pocos;
using Northwind.Contracts;
namespace Northwind.BLL
{
    public class ProductBusinessLogic : IProduct
    {
        private ProductDataAccess dal = new ProductDataAccess();

        public SelectProductByIDDM SelectProductByID(int productID)
        {

            SelectProductByIDDM product = dal.SelectProductByID(productID);

            if(product == null)
            {
                product = new SelectProductByIDDM();
            }

            return product;
        }

        public int SelectProductCount()
        {
            int productCount = dal.SelectProductCount();

            return productCount;


        }

        public List<SelectProductsByCategoryIDDM> SelectProductsByCategoryID(int categoryID)
        {
            List<SelectProductsByCategoryIDDM> products = dal.SelectProductsByCategoryID(categoryID);

            if(products == null)
            {
                products = new List<SelectProductsByCategoryIDDM>();
            }

            return products;
        }
    }
}