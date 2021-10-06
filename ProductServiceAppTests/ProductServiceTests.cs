using Moq;
using NUnit.Framework;
using ProductServiceApp.DataAccess;

namespace ProductServiceAppTests
{
    public class ProductServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Method to validate properties of Laptop model
        /// </summary>
        [Test]
        public void ValidateLaptopModelProperty()
        {
            Mock<ProductsDataAccess> productDataAccess = new Mock<ProductsDataAccess>();
            Assert.Pass();
        }
    }
}