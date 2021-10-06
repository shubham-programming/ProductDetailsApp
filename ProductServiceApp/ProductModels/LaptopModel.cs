using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.Models
{
    /// <summary>
    /// Laptop Model Class inheriting Product Details Model Class and having PriceDetailsModel as property
    /// </summary>
    public class LaptopModel : ProductDetailsModel
    {
        public string Docking { get; set; }
        public PriceDetailsModel PriceDetails { get; set; }

        public LaptopModel(string Category) : base (Category)
        {
            
        }
    }
}
