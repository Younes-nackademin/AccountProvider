using System.Collections.Generic;
using System.Linq;
using AccountProvider.Data.Contexts;
using AccountProvider.Data.Interfaces;
using AccountProvider.Domain.Models;

namespace AccountProvider.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        //Skapare för att lägga in databaskontexten.
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
