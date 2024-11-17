using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountProvider.Data.Contexts;
using AccountProvider.Domain.Models;

namespace AccountProvider.Tests.IntegrationTests
{
    [TestClass]
    public class DatabaseIntegrationTests
    {
        private ApplicationDbContext? _context;

        [TestInitialize]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDatabase")
                .Options;

            _context = new ApplicationDbContext(options);
            _context.Database.EnsureDeleted(); // Kontrollerar att databasen är tom före varje test.
            _context.Database.EnsureCreated(); // Skapar databasen på nytt för testningen.
        }

        [TestMethod]
        public void ShouldAddProductToDatabase()
        {
            var product = new Product
            {
                Id = 1,
                Name = "Test Product",
                Price = 100,
                Description = "Integration Test Product"
            };

            _context!.Products.Add(product);
            _context.SaveChanges();

            var savedProduct = _context.Products.Find(1);
            Assert.IsNotNull(savedProduct, "Produkten kunde inte sparas i databasen.");
            Assert.AreEqual("Test Product", savedProduct.Name);
        }

        [TestMethod]
        public void ShouldAddUserToDatabase()
        {
            var user = new User
            {
                Id = 1,
                Username = "TestUser",
                Password = "Password123",
                Email = "test@example.com"
            };

            _context!.Users.Add(user);
            _context.SaveChanges();

            var savedUser = _context.Users.Find(1);
            Assert.IsNotNull(savedUser, "Användaren kunde inte sparas i databasen.");
            Assert.AreEqual("TestUser", savedUser.Username);
        }
    }
}
