using ProductServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.ProductBLL
{
    public interface IProductBLL
    {
        int InsertLaptopDetails(List<LaptopModel> Laptops);

        int InsertDesktopDetails(List<DesktopModel> Desktops);
    }
}
