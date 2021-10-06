using ProductServiceApp.Models;
using ProductServiceApp.ProductBLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.ProductService
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;

        public  ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public int InsertLaptopDetails(List<LaptopModel> Laptops)
        {
            /*Logic to return count of rows inserted from dataAccess */

            return _productsRepository.InsertLaptopDetails(Laptops);
        }

        public int InsertDesktopDetails(List<DesktopModel> Desktops)
        {
            /*Logic to return count of rows inserted from dataAccess */

            return _productsRepository.InsertDesktopDetails(Desktops);
        }
    }
}
