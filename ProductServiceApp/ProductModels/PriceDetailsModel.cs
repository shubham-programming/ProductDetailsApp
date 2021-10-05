using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.Models
{
    public class PriceDetailsModel
    {
        public decimal OrignalPrice { get; set; }

        public decimal AvailableDiscount { get; set; }

        public decimal GST { get; set; }

        public decimal ShippingPrice { get; set; }
    }
}
