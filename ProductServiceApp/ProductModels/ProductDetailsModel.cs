using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductServiceApp.Models
{
    /// <summary>
    /// Product Details Model Class
    /// </summary>
   public class ProductDetailsModel
    {
        [Required(ErrorMessage = "Product Category is required field")]
        public string Category { get; set; }
        public string Product { get; set; }
        public int MemoryCapacity { get; set; }
        public string Display { get; set; }

        public ProductDetailsModel(string Category)
        {
            this.Category = Category;
        }
    }

     
}
