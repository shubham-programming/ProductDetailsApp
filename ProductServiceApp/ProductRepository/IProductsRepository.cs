using ProductServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.ProductBLL
{
    public interface IProductsRepository
    {
        int InsertLaptopDetails(List<LaptopModel> LaptopDetails);
        int InsertDesktopDetails(List<DesktopModel> desktopDetails);
    }
}
