using AccountProvider.Business.Interfaces;
using AccountProvider.Data.Interfaces;
using AccountProvider.Domain.Models;

namespace AccountProvider.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        // skapare för att lägga ett användar-repository (lagring och hämtning)
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(string username, string password)
        {
            var user = new User { Username = username, Password = password };
            _userRepository.AddUser(user);
        }

        public bool DeleteUser(int userId)
        {
            var user = _userRepository.GetUserById(userId);
            if (user != null)
            {
                _userRepository.DeleteUser(userId);
                return true;
            }
            return false;
        }

        public void UpdateUser(int userId, string newUsername)
        {
            var user = _userRepository.GetUserById(userId);
            if (user != null)
            {
                user.Username = newUsername;
                _userRepository.UpdateUser(user);
            }
        }
    }
}
