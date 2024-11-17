using AccountProvider.Domain.Models;

namespace AccountProvider.Business.Interfaces
{
    public interface IProductService
    {
        void AddProduct(string name, decimal price);
        bool DeleteProduct(int productId);
        void UpdateProduct(int productId, string newName, decimal newPrice);
    }
}
