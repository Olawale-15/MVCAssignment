using MVCAssignment.Models;

namespace MVCAssignment.Interface
{
	public interface IUserService
	{
		Task<User> CreateUser(User user);
		Task<User> UpdateUser(User user, int id);
		Task<bool> DeleteUser(int id);
		Task<User> GetUserById(int id);
		Task<IList<User>> GetAllUser();
	}
}
