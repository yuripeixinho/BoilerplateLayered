using Microsoft.EntityFrameworkCore;
using TF.Core.Domain;
using TF.Data.Context;
using TF.Manager.Interfaces.Repositories;

namespace TF.Data.Repository;

public class UserRepository : IUserRepository
{
    private readonly TFContext _context;    

    public UserRepository(TFContext context)
    {
        _context = context; 
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        var users = await _context.Users.ToListAsync();

        return users;
    }
}
