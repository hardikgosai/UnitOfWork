using Getri_UnitOfWork.Models;

namespace Getri_UnitOfWork.Repository
{
    public interface IUserRepository
    {
        User GetUser(int userId);
        User GetUserByName(string userName);
        void AddUser(User user);
        void UpdateUser(User user);
        bool DeleteUser(int userId);
        IEnumerable<User> GetUsers();
    }
}
