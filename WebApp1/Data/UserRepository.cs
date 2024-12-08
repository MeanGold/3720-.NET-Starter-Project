using System.Diagnostics.Eventing.Reader;
using WebApp1.Data.Entities;
namespace WebApp1.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly TigerTixContext _context;
        public UserRepository(TigerTixContext context)
        {
            _context = context;
        }

        // Create a User
        public void CreateUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        // Returns all users
        public IEnumerable<User> GetAllUsers()
        {
            var users = from u in _context.Users
                        select u;
            return users.ToList();
        }

        public User GetUsersByID(int userID)
        {
            var user = (from u in _context.Users
                        where u.Id == userID
                        select u).FirstOrDefault();
            return user;
        }
        public User GetUsersByUsername(string username)
        {
            var user = (from u in _context.Users
                        where u.UserName == username
                        select u).FirstOrDefault();
            return user;
        }

        public int ValidateUser(string username, string password)
        {
            int retVal = 0;
            if (string.IsNullOrEmpty(username))
            {
                retVal = -1;
            } else
            {
                User user = (from u in _context.Users
                             where u.UserName == username
                             select u).FirstOrDefault()!;

                retVal = (user.Password == password) ? user.Id : -2;
            }
            
            //int retVal = (user != null ? user.Id : -1);

            return retVal; 
        }

        // Update a user
        public void UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }

        // Delete a user
        public void DeleteUser(User user)
        {
            _context.Remove(user);
            _context.SaveChanges();
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
