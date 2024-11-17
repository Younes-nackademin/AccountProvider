using AccountProvider.Domain.Models;

namespace AccountProvider.Data.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUserById(int userId);
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
