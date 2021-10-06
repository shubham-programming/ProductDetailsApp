using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.Models
{
    public class DesktopModel : ProductDetailsModel
    {
        public string PerformanceOptions { get; set; }

        public int SSDStorage { get; set; }

        public PriceDetailsModel PriceDetails { get; set; }

        public DesktopModel(string Category) : base (Category){ }
    }
}
