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
    public class CategoryController : ApiController, ICategory
    {

        private CategoryBusinessLogic bll = new CategoryBusinessLogic();

        [HttpGet]
        [Route("Category/SelectAllCategories")]
        public List<SelectAllCategoriesDM> SelectAllCategories()
        {
            List<SelectAllCategoriesDM> categories = bll.SelectAllCategories();

            return categories;
        }
    }
}
