using ProductServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.DataAccess
{
    public interface IProductsDataAccess
    {
        int InsertLaptopCategoryProducts(List<LaptopModel> LaptopDetails);
        int InsertDesktopCategoryProducts(List<DesktopModel> desktopDetails);
    }
}
