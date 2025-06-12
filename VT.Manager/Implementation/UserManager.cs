using VT.Core.Shared.ModelViews.User;
using VT.Manager.Interfaces.Manager;
using VT.Manager.Interfaces.Repositories;

namespace VT.Manager.Implementation;

public class UserManager : IUserManager
{
    private readonly IUserRepository _userRepository;

    public UserManager(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<UserDTO>> GetUsersAsync()
    {
        var users = await _userRepository.GetUsersAsync();

        var userDTO = users.Select(u => new UserDTO
        {
            Id = u.Id,
            Name = u.Name,
        });

        return userDTO; 
    }
}
