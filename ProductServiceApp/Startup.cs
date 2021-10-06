using Microsoft.Extensions.DependencyInjection;
using ProductServiceApp.DataAccess;
using ProductServiceApp.ProductBLL;
using ProductServiceApp.ProductService;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace ProductServiceApp
{
    /// <summary>
    /// Class to configure and register dependencies of application
    /// </summary>
   public class Startup
    {
        public IConfiguration Configuration;
        public ServiceCollection services = new ServiceCollection();

        public void Configure()
        {
            // pre requisite : environment variable - ENVIRONMENT in application running environment.
            string enviornment = Environment.GetEnvironmentVariable("ENVIRONMENT");
            enviornment = "Development"; // Hard coded only for app running purpose , real time application should read from env variable of server/cloud platforms.

            // Add Configuration from appsettings.{env}.json using Configuration builder.  

            ConfigureServices();
           
        }
        public void ConfigureServices()
        {
            services.AddTransient<IProductsDataAccess, ProductsDataAccess>(i => new ProductsDataAccess(GetConnectionString()));
            services.AddTransient<IProductsRepository, ProductsRepository>(i => new ProductsRepository(i.GetService<IProductsDataAccess>()));
            services.AddTransient<IProductsService, ProductsService>(i => new ProductsService(i.GetService<IProductsRepository>()));
        }

        public string GetConnectionString()
        {
            return $"{Configuration.GetConnectionString("DbConn")}";
        }
    }
}
