using MVCAssignment.Models;

namespace MVCAssignment.Interface
{
	public interface IUserRepository
	{
		Task<User> CreateUser(User user);
		Task<User> UpdateUser(User user);
		Task<bool> DeleteUser(User user);	
		Task<User> GetUser(int id);
		Task<IList<User>> GetAllUsers();
	}
}
