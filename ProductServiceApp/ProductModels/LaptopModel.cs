using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.Models
{
    public class LaptopModel : ProductDetailsModel
    {
        public string Docking { get; set; }
        public PriceDetailsModel PriceDetails { get; set; }
    }
}
