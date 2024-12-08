using WebApp1.Data.Entities;

namespace WebApp1.Data
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        void DeleteUser(User user);
        IEnumerable<User> GetAllUsers();
        User GetUsersByID(int userID);
        User GetUsersByUsername(string username);

        int ValidateUser(string username, string password);
        bool SaveAll();
        void UpdateUser(User user);
    }
}