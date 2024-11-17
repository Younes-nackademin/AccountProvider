using AccountProvider.Data.Contexts;
using AccountProvider.Domain.Models;
using System.Linq;

namespace AccountProvider.Data.Databases
{
    // Lägger databasen med testdata om den är skulle vara tom.
    public static class DatabaseInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            // Lägger till eb testanvändare om inga användare skulle finnas i databasen.
            if (!context.Users.Any())
            {
                context.Users.Add(new User { Username = "testuser", Password = "password123" });
                context.Users.Add(new User { Username = "adminuser", Password = "adminpassword" });
                context.SaveChanges();
            }

            // Lägger till testprodukter om inga produkter skulle finnas i databasen.
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Product A", Price = 100 },
                    new Product { Name = "Product B", Price = 200 },
                    new Product { Name = "Product C", Price = 300 }
                );
                context.SaveChanges();
            }

            // Lägger till testordrar om inga ordrar finns i databasen.
            if (!context.Orders.Any())
            {
                context.Orders.Add(new Order { UserId = 1, ProductName = "Product A", Status = "Pending" });
                context.Orders.Add(new Order { UserId = 1, ProductName = "Product B", Status = "Completed" });
                context.SaveChanges();
            }
        }
    }
}
