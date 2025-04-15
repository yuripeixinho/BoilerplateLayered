using TF.Core.Shared.ModelViews.Conta;

namespace TF.Manager.Interfaces.Manager;

public interface IUserManager
{
    Task<IEnumerable<UserDTO>> GetUsersAsync();
}
