using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.Pocos;
using Northwind.Contracts;
namespace Northwind.DAL
{
    /// <summary>
    /// The CategoryDataAccess class contains crud methods
    /// that manipulates the Categories in the Northwind Database
    /// </summary>
    public class CategoryDataAccess : ICategory
    {
        /// <summary>
        /// SelectAllCategories pulls all rows from
        /// the Categories table for column info refer to 
        /// CategoryDM Documentation
        /// </summary>
        /// <returns>List of type CategoryDM objects</returns>
        public List<SelectAllCategoriesDM> SelectAllCategories()
        {
            List<SelectAllCategoriesDM> categories = new List<SelectAllCategoriesDM>();

            using (Northwind northwindContext = new Northwind())
            {
                categories = northwindContext.SelectAllCategories();

            }

            return categories;
        }
    }
}