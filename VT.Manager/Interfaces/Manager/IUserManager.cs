using VT.Core.Shared.ModelViews.User;

namespace VT.Manager.Interfaces.Manager;

public interface IUserManager
{
    Task<IEnumerable<UserDTO>> GetUsersAsync();
}
