using System;
using ProductServiceApp.Constants;
using ProductServiceApp.Models;

namespace ProductServiceApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string continueInput = Variables.ContinueInput;
            while(continueInput.ToUpper().Equals(Variables.ContinueInput))
            {
                Console.WriteLine("Enter Product Category");
                string productCategory = Console.ReadLine();
                switch(productCategory)
                {
                    case Variables.LaptopCategory:
                        ProductDetailsModel laptopDetails = new LaptopModel();
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
