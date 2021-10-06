using ProductServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.ProductModels
{
    public class ProductsListModel
    {
        public List<LaptopModel> laptopModels { get; set; }
        public List<DesktopModel> desktopModels { get; set; }
    }
}
