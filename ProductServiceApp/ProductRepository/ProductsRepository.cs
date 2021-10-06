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

        /// <summary>
        /// Constructor Dependency Injection to create product dataAccess objects
        /// </summary>
        /// <param name="productsRepository"></param>
        public ProductsRepository (IProductsDataAccess productsDataAccess)
        {
            _productsDataAccess = productsDataAccess;
        }

        /// <summary>
        /// Method to insert List of Laptop products in Database
        /// </summary>
        /// <param name="Laptops"></param>
        /// <returns></returns>
        public int InsertLaptopDetails(List<LaptopModel> Laptops)
        {
            /*Logic to return count of rows inserted from dataAccess */

            return _productsDataAccess.InsertLaptopCategoryProducts(Laptops);
        }

        /// <summary>
        /// Method to insert List of Desktop products in Database
        /// </summary>
        /// <param name="Laptops"></param>
        /// <returns></returns>
        public int InsertDesktopDetails(List<DesktopModel> Desktops)
        {
            /*Logic to return count of rows inserted from dataAccess */

            return _productsDataAccess.InsertDesktopCategoryProducts(Desktops);
        }
    }
}
