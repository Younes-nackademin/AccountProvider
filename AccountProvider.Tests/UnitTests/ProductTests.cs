using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountProvider.Domain.Models;

namespace AccountProvider.Tests.UnitTests
{
    [TestClass]
    public class ProductTests
    {
        // Testar att en produkt har rätt egenskaper när den ska skapas.
        [TestMethod]
        public void Product_ShouldHaveCorrectProperties()
        {
            var product = new Product
            {
                Id = 1,
                Name = "Test Product",
                Price = 200,
                Description = "This is a test product."
            };

            Assert.AreEqual(1, product.Id);
            Assert.AreEqual("Test Product", product.Name);
            Assert.AreEqual(200, product.Price);
            Assert.AreEqual("This is a test product.", product.Description);
        }

        // Testar att produkten har rätt pris.
        [TestMethod]
        public void Product_ShouldHaveCorrectPrice()
        {
            var product = new Product
            {
                Id = 2,
                Name = "Another Product",
                Price = 500,
                Description = "This is another test product."
            };

            Assert.AreEqual(500, product.Price);
        }

        // Testar att produktens beskrivning inte är null.
        [TestMethod]
        public void Product_ShouldHaveNonNullDescription()
        {
            var product = new Product
            {
                Id = 3,
                Name = "Non-null Description Product",
                Price = 150,
                Description = "This product has a non-null description."
            };

            Assert.IsNotNull(product.Description);
        }
    }
}
