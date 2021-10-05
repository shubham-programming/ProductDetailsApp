using ProductServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ProductServiceApp.DataAccess
{
    public class ProductsDataAccess : IProductsDataAccess
    {
        private string _connectionString { get; set; }
        public ProductsDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int InsertLaptopCategoryProducts(List<LaptopModel> LaptopDetails)
        {
            int count = 0; // count of records inserted through List of Laptop Model
            using (var connection = new SqlConnection(_connectionString))
            {
                /*logic to insert list of Laptop Model as per Laptop Category of Product Table
                 * Update value of count with rows inserted.
                 */
            }
            return count;
        }

        public int InsertDesktopCategoryProducts(List<DesktopModel> DesktopDetails)
        {
            int count = 0; // count of records inserted through List of Laptop Model
            using (var connection = new SqlConnection(_connectionString))
            {
                /*logic to insert list of Desktop Model as per Desktop Category of Product Table
                 * Update value of count with rows inserted.
                 */
            }
            return count;
        }
    }
}
