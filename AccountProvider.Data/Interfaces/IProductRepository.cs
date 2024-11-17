using System.Collections.Generic;
using AccountProvider.Domain.Models;

namespace AccountProvider.Data.Interfaces
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        Product GetProductById(int productId);
        IEnumerable<Product> GetAllProducts();
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }
}
