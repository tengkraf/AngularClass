using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Northwind.BLL;
using Northwind.Pocos;
using Northwind.Contracts;
namespace Northwind.WebApi.Controllers
{
    public class ProductController : ApiController, IProduct
    {

        private ProductBusinessLogic bll = new ProductBusinessLogic();

        [HttpGet]
        [Route("Product/SelectProductByID/{productID}")]
        public SelectProductByIDDM SelectProductByID(int productID)
        {
            SelectProductByIDDM product = bll.SelectProductByID(productID);

            return product;
        }

        [HttpGet]
        [Route("Product/SelectProductCount")]
        public int SelectProductCount()
        {
            int productCount = bll.SelectProductCount();

            return productCount;
        }

        [HttpGet]
        [Route("Product/SelectProductsByCategoryID/{categoryID}")]
        public List<SelectProductsByCategoryIDDM> SelectProductsByCategoryID(int categoryID)
        {
            List<SelectProductsByCategoryIDDM> products = bll.SelectProductsByCategoryID(categoryID);

            return products;
        }
    }
}
