using TF.Core.Domain;

namespace TF.Manager.Interfaces.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
}
