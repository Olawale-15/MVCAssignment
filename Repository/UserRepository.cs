using Microsoft.EntityFrameworkCore;
using MVCAssignment.Context;
using MVCAssignment.Interface;
using MVCAssignment.Models;

namespace MVCAssignment.Repository
{
	public class UserRepository:IUserRepository
	{
		private readonly ApplicationContext _applicationContext;
        public UserRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task<User> CreateUser(User user)
        {
            await _applicationContext.Users.AddAsync(user);
            await _applicationContext.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUser(User user)
        {
            _applicationContext.Users.Update(user);
            await _applicationContext.SaveChangesAsync();
            return user;
        }

        public async Task<bool> DeleteUser(User user)
        {
            _applicationContext.Users.Remove(user);
            await _applicationContext.SaveChangesAsync();
            return true;
        }

        public async Task<User?> GetUser(int id)
        {
            var getUser = await _applicationContext.Users.FindAsync(id);
            return getUser;
        }

        public async Task<IList<User>> GetAllUsers()
        {
            var users = await _applicationContext.Users.ToListAsync();
            return users;
        }
    }
}
