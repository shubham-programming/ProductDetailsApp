using System;
using Microsoft.Extensions.DependencyInjection;
using ProductServiceApp.Constant;
using ProductServiceApp.Models;
using ProductServiceApp.ProductService;

namespace ProductServiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Startup startup = new Startup();
            startup.Configure();
            var productService = startup.services.BuildServiceProvider().GetService<IProductsService>();
            productService.ReadProductDetailsFromConsole();
        }
    }
}
