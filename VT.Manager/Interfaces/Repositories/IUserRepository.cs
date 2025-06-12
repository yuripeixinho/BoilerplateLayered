using VT.Core.Domain;

namespace VT.Manager.Interfaces.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
}
