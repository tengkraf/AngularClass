using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.Pocos;
namespace Northwind.Contracts
{
    public interface IProduct
    {
        List<SelectProductsByCategoryIDDM> SelectProductsByCategoryID(int categoryID);

        SelectProductByIDDM SelectProductByID(int productID);

        int SelectProductCount();
    }
}