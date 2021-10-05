using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.Models
{
   public class ProductDetailsModel
    {
        public string Category { get; set; }
        public string Product { get; set; }

        public int MemoryCapacity { get; set; }

        public float Display { get; set; }
         
    }
}
