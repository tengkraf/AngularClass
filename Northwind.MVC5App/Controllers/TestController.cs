using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.MVC5App.ViewModels;
namespace Northwind.MVC5App.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(InsertViewModel model)
        {

            ProductViewModel product = model.Product;
            CategoryViewModel category = model.Category;
            
            return View();
        }
    }
}