using ProductServiceApp.Constant;
using ProductServiceApp.Models;
using ProductServiceApp.ProductBLL;
using ProductServiceApp.ProductModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductServiceApp.ProductService
{
    /// <summary>
    /// Product Service to read input from console and transfer data to repository level
    /// </summary>
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;

        /// <summary>
        /// Constructor Dependency Injection to create product repository objects
        /// </summary>
        /// <param name="productsRepository"></param>
        public  ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }


        /// <summary>
        /// Method to read input from console and parse values into category based models
        /// </summary>
        public void ReadProductDetailsFromConsole()
        {
            int laptopInsertCount = 0;
            int DesktopInsertCount = 0;
            ProductsListModel productsList = new ProductsListModel();  // Product List Model Intialization
            productsList.laptopModels = new List<LaptopModel>();
            productsList.desktopModels = new List<DesktopModel>();
            string continueInput = Constants.ContinueInput;
            while (continueInput.ToUpper().Equals(Constants.ContinueInput)) // while console input is Yes - Read Product Details
            {
                Console.Write("Category:  ");
                string productCategory = Console.ReadLine();
                switch (productCategory.ToUpper())
                {
                    //Create object according to product category, ex - Laptop , Desktop etc.
                    case Constants.LaptopCategory:
                        var laptopModel = AssignLaptopModelAttributes(productCategory);
                        productsList.laptopModels.Add(laptopModel);
                        continueInput = AskforInput();
                        break;
                    case Constants.DesktopCategory:
                        var desktopModel = AssignDesktopModelAttributes(productCategory);
                        productsList.desktopModels.Add(desktopModel);
                        continueInput = AskforInput();
                        break;
                    default:
                        Console.WriteLine("Invalid Category Entered");
                        continueInput = AskforInput();
                        break;
                }
            }

            if(productsList.laptopModels.Count>0)
            {
                laptopInsertCount = InsertLaptopDetails(productsList.laptopModels);
            }
            if(productsList.desktopModels.Count > 0)
            {
                DesktopInsertCount = InsertDesktopDetails(productsList.desktopModels);
            }
        }

        /// <summary>
        /// Method to insert List of Laptop product in Database using Repository
        /// </summary>
        /// <param name="Laptops"></param>
        /// <returns>Count</returns>
        public int InsertLaptopDetails(List<LaptopModel> Laptops)
        {
            /*Logic to return count of rows inserted from dataAccess */

            return _productsRepository.InsertLaptopDetails(Laptops);
        }

        /// <summary>
        /// Method to insert List of Desktop product in Database using Repository
        /// </summary>
        /// <param name="Desktops"></param>
        /// <returns>Count</returns>
        public int InsertDesktopDetails(List<DesktopModel> Desktops)
        {
            /*Logic to return count of rows inserted from dataAccess */

            return _productsRepository.InsertDesktopDetails(Desktops);
        }

        /// <summary>
        /// Method to read values from console and Assign to Laptop Data Model
        /// </summary>
        /// <param name="productCategory"></param>
        /// <returns>LaptopModel</returns>
        private LaptopModel AssignLaptopModelAttributes(string productCategory)
        {
            LaptopModel laptopDetails = new LaptopModel(productCategory);            
            Console.Write("\n Product: ");
            laptopDetails.Product = Console.ReadLine();
            if (String.IsNullOrEmpty(laptopDetails.Product))
            {
                Console.WriteLine("Product under Category cannot be empty.Enter the product");
                // increment Counter can be implemented to check if product detail is asked if null value for defined times. (for ex-5 times) then re ask product category
            }
            Console.Write("\n PricingDetail: Orignal Price: ");
            laptopDetails.PriceDetails.OrignalPrice = decimal.Parse(Console.ReadLine());
            Console.Write(", GST: ");
            laptopDetails.PriceDetails.GST = decimal.Parse(Console.ReadLine());
            Console.Write("%, Shipping Price: $");
            laptopDetails.PriceDetails.ShippingPrice = decimal.Parse(Console.ReadLine());
            Console.Write("/n ProductDetail: Memory Capacity: ");
            laptopDetails.MemoryCapacity = int.Parse(Console.ReadLine());
            Console.Write("GB, display:");
            laptopDetails.Display = Console.ReadLine();
            Console.WriteLine("Docking");
            laptopDetails.Docking = Console.ReadLine();
            return laptopDetails;
        }

        /// <summary>
        /// Method to read values from console and Assign to Desktop Data Model
        /// </summary>
        /// <param name="productCategory"></param>
        /// <returns>DesktopModel</returns>
        private DesktopModel AssignDesktopModelAttributes(string productCategory)
        {
            DesktopModel desktopDetails = new DesktopModel(productCategory);
            Console.Write("\n Product: ");
            desktopDetails.Product = Console.ReadLine();
            if (String.IsNullOrEmpty(desktopDetails.Product))
            {
                Console.WriteLine("Product under Category cannot be empty.Enter the product");
                // increment Counter can be implemented to check if product detail is asked if null value for defined times. (for ex-5 times) then re ask product category
            }
            Console.Write("\n PricingDetail: Orignal Price: ");
            desktopDetails.PriceDetails.OrignalPrice = decimal.Parse(Console.ReadLine());
            Console.Write(", GST: ");
            desktopDetails.PriceDetails.GST = decimal.Parse(Console.ReadLine());
            Console.Write("%, Shipping Price: $");
            desktopDetails.PriceDetails.ShippingPrice = decimal.Parse(Console.ReadLine());
            Console.Write("/n ProductDetail: Memory Capacity: ");
            desktopDetails.MemoryCapacity = int.Parse(Console.ReadLine());
            Console.Write("GB, display:");
            desktopDetails.Display = Console.ReadLine();
            Console.WriteLine("Docking");
            desktopDetails.PerformanceOptions = Console.ReadLine();
            return desktopDetails;
        }

        private string AskforInput()
        {
            Console.WriteLine("Do you want to Add more Categories (Yes/No)");
            return Console.ReadLine();
        }


    }
}
