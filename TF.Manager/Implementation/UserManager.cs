using TF.Core.Shared.ModelViews.Conta;
using TF.Manager.Interfaces.Manager;
using TF.Manager.Interfaces.Repositories;

namespace TF.Manager.Implementation;

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
