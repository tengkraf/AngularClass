using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.MVC5App.ViewModels;

namespace Northwind.MVC5App.Controllers
{
    
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ActionResult ShowEmployees()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateEmployee()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateEmployee(CreateEmployeeViewModel employee)
        {

            if(ModelState.IsValid)
            {
                //add insert logic
                NorthwindServiceController webApi = new NorthwindServiceController();
                int rowsAffected = webApi.InsertEmployee(employee);
                if(rowsAffected == 1)
                {
                    return RedirectToAction("ShowEmployees");
                }

                
            }

            return View();
        }


        //Not Preferred technique all server side
        //public ActionResult ShowEmployeesRazor()
        //{
        //    NorthwindServiceController webApi = new NorthwindServiceController();
        //    List<ShowEmployeesViewModel> model = webApi.GetAllEmployees();

        //    return View(model);
        //}

        public ActionResult ShowEmployees2()
        {
            
            return View();
        }

        public PartialViewResult GetEmployeesTable()
        {
            NorthwindServiceController webApi = new NorthwindServiceController();
            List<ShowEmployeesViewModel> model = webApi.GetAllEmployees();
            return PartialView("EmployeesTable",model);
        }


    }
}