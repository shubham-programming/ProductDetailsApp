using ProductServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.ProductService
{
    public interface IProductsService
    {
        int InsertLaptopDetails(List<LaptopModel> Laptops);

        int InsertDesktopDetails(List<DesktopModel> Desktops);

        void ReadProductDetailsFromConsole();
    }
}
