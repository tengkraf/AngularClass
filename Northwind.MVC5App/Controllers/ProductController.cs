using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.MVC5App.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public ActionResult SearchProducts()
        {
            return View();
        }
    }
}