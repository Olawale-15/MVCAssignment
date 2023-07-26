using MVCAssignment.Interface;
using MVCAssignment.Models;

namespace MVCAssignment.Service
{
	public class UserService
	{
		private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> CreateUser(User user)
        {
            var createUser = new User()
            {
                UserName = user.UserName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
            };
           var addUser = await _userRepository.CreateUser(createUser);
            return addUser;
        }

        public async Task<User> UpdateUser(User user, int id)
        {
            var getUser = await _userRepository.GetUser(id);
            if (getUser == null)
            {
                throw new ArgumentNullException(nameof(getUser));
            }
            var updateUser = new User();
            updateUser.UserName = user.UserName;
            updateUser.LastName = user.LastName;
            updateUser.Email = user.Email;
            updateUser.Password = user.Password;
            var update = await _userRepository.UpdateUser(updateUser);
            return update;
        }

        public async Task<bool> DeleteUser(int id)
        {
            var getUser = await _userRepository.GetUser(id);
            if(getUser == null)
            {
                throw new ArgumentNullException(nameof(getUser));
            }
            await _userRepository.DeleteUser(getUser);
            return true;
        }

        public async Task<User> GetUser(int id)
        {
            var getUser = await _userRepository.GetUser(id);
            if(getUser == null)
            {
                throw new ArgumentNullException(nameof(getUser));
            }
            var user = new User
            {
                Id = getUser.Id,
                UserName = getUser.UserName,
                LastName = getUser.LastName,
                Email = getUser.Email,
            };
            return user;
        }

          public async Task<IList<User>> GetAllUser()
        {
            var getAllUsers = await _userRepository.GetAllUsers();
            var listOfAllUsers = getAllUsers.Select(x => new User()
            {
                Id = x.Id,
                Email = x.Email,
                UserName = x.UserName,
                LastName = x.LastName,

            }).ToList();
            return listOfAllUsers;
        }
    }
}
