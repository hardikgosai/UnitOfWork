using Getri_UnitOfWork.EntityFramework;
using Getri_UnitOfWork.Models;

namespace Getri_UnitOfWork.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext dbContext;

        public UserRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void AddUser(User user)
        {
            dbContext.User.Add(user);
        }

        public bool DeleteUser(int userId)
        {
            var isDeleted = false;
            var user = GetUser(userId);
            if (user != null)
            {
                dbContext.User.Remove(user);
                isDeleted = true;
            }
            return isDeleted;
        }

        public User GetUser(int userId)
        {
            return dbContext.User.Find(userId);
        }

        public IEnumerable<User> GetUsers()
        {
            return dbContext.User.ToList();
        }

        public void UpdateUser(User user)
        {
            var userToUpdate = dbContext.User.Find(user.UserId);
            if (userToUpdate != null)
            {
                userToUpdate.UserName = user.UserName;
                userToUpdate.UserEmail = user.UserEmail;
                userToUpdate.UserContactNo = user.UserContactNo;
                userToUpdate.UserAddress = user.UserAddress;
                
                dbContext.User.Update(userToUpdate);
            }
            
        }

        public User GetUserByName(string userName)
        {
            return dbContext.User.FirstOrDefault(u => u.UserName == userName);
        }
    }
}
