using AccountProvider.Domain.Models;

namespace AccountProvider.Business.Interfaces
{
    public interface IUserService
    {
        void CreateUser(string username, string password);
        bool DeleteUser(int userId);
        void UpdateUser(int userId, string newUsername);
    }
}
