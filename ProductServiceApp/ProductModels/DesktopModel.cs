using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.Models
{
    public class DesktopModel
    {
        public List<string> PerformanceOptions { get; set; }

        public int SSDStorage { get; set; }

        public PriceDetailsModel PriceDetails { get; set; }
    }
}
