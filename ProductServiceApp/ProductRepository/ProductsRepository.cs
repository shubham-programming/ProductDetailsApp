using ProductServiceApp.DataAccess;
using ProductServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.ProductBLL
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly IProductsDataAccess _productsDataAccess;
        public ProductsRepository (IProductsDataAccess productsDataAccess)
        {
            _productsDataAccess = productsDataAccess;
        }

        public int InsertLaptopDetails(List<LaptopModel> Laptops)
        {
            /*Logic to return count of rows inserted from dataAccess */

            return _productsDataAccess.InsertLaptopCategoryProducts(Laptops);
        }

        public int InsertDesktopDetails(List<DesktopModel> Desktops)
        {
            /*Logic to return count of rows inserted from dataAccess */

            return _productsDataAccess.InsertDesktopCategoryProducts(Desktops);
        }
    }
}
