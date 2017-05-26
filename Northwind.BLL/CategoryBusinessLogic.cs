using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.DAL;
using Northwind.Pocos;
using Northwind.Contracts;
namespace Northwind.BLL
{
    public class CategoryBusinessLogic : ICategory
    {
        private CategoryDataAccess dal = new CategoryDataAccess();
        public List<SelectAllCategoriesDM> SelectAllCategories()
        {
            List<SelectAllCategoriesDM> categories = dal.SelectAllCategories();

            if(categories == null)
            {
                categories = new List<SelectAllCategoriesDM>();
            }

            return categories;
        }
    }
}