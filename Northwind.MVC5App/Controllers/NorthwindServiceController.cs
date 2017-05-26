using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Northwind.MVC5App.ViewModels;
using Newtonsoft.Json;
namespace Northwind.MVC5App.Controllers
{
    public class NorthwindServiceController : ApiController
    {


        [HttpGet]
        [Route("NorthwindService/GetAllEmployees")]
        public List<ShowEmployeesViewModel> GetAllEmployees()
        {
            //call the external web api
            string route = "http://localhost:8140/Employee/SelectAllEmployees";
            List<ShowEmployeesViewModel> employees = new List<ShowEmployeesViewModel>();
            //use the WebClient class
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(route);
                //
                employees = JsonConvert.DeserializeObject<List<ShowEmployeesViewModel>>(json);
            }

            return employees;
        }

        [HttpGet]
        [Route("NorthwindService/GetAllCategories")]
        public List<CategoryViewModel> GetAllCategories()
        {
           
            string route = "http://localhost:8140/Category/SelectAllCategories";
            List<CategoryViewModel> categories = new List<CategoryViewModel>();
           
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(route);
                
                categories = JsonConvert.DeserializeObject<List<CategoryViewModel>>(json);
            }

            return categories;
        }

        [HttpGet]
        [Route("NorthwindService/GetProductsByCategoryID/{categoryID}")]
        public List<ProductViewModel> GetProductsByCategoryID(int categoryID)
        {

            string route = "http://localhost:8140/Product/SelectProductsByCategoryID/" + categoryID;

            List<ProductViewModel> products = new List<ProductViewModel>();

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(route);

                products = JsonConvert.DeserializeObject<List<ProductViewModel>>(json);
            }

            return products;
        }


        [HttpGet]
        [Route("NorthwindService/GetProductByID/{productID}")]
        public ProductByIDViewModel GetProductByID(int productID)
        {
            //call the external web api and desearlize the json to c#
            string route = "http://localhost:8140/Product/SelectProductByID/" + productID;

            //create your return object
            ProductByIDViewModel product = new ProductByIDViewModel();

            //create a webclinet object to the call webpi
            using (WebClient client = new WebClient())
            {
                //retrieves the data from webapi as json
                string json = client.DownloadString(route);

                //newtonsoft.net deserialize json to c#
                product = JsonConvert.DeserializeObject<ProductByIDViewModel>(json);
            }

            return product;

        }



        public int InsertEmployee(CreateEmployeeViewModel employee)
        {
            string route = "http://localhost:8140/Employee/InsertEmployee";
            int rowsAffected = 0;

            using (WebClient client = new WebClient())
            {
                string json = JsonConvert.SerializeObject(employee);
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                string response = client.UploadString(route, json);

                rowsAffected = int.Parse(response);
            }

            return rowsAffected;
        }

        [HttpGet]
        [Route("NorthwindService/GetProductCount")]
        public int GetProductCount()
        {
            string route = "http://localhost:8140/Product/SelectProductCount";
            int productCount = 0;

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(route);

                productCount = JsonConvert.DeserializeObject<int>(json);
            }

            return productCount;

        }

    }
}
