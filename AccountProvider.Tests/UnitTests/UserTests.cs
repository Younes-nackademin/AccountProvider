using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountProvider.Domain.Models;

namespace AccountProvider.Tests.UnitTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void User_ShouldHaveCorrectProperties()
        {
            var user = new User
            {
                Id = 1,
                Username = "TestUser",
                Password = "Password123",
                Email = "test@example.com"
            };

            // Kollae att användaren har rätt egenskaper.
            Assert.AreEqual(1, user.Id);
            Assert.AreEqual("TestUser", user.Username);
            Assert.AreEqual("Password123", user.Password);
            Assert.AreEqual("test@example.com", user.Email);
        }
    }
}
