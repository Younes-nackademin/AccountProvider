using Microsoft.EntityFrameworkCore;
using AccountProvider.Domain.Models;

namespace AccountProvider.Data.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; } // Tabell för ordrar.
        public DbSet<User> Users { get; set; } // Tabell för användare.
        public DbSet<Product> Products { get; set; } // Tabell för produkter.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //specifika inställning läggs här.
        }
    }
}
