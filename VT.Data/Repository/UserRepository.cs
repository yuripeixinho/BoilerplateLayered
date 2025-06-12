using Microsoft.EntityFrameworkCore;
using VT.Core.Domain;
using VT.Data.Context;
using VT.Manager.Interfaces.Repositories;

namespace VT.Data.Repository;

public class UserRepository : IUserRepository
{
    private readonly VTContext _context;    

    public UserRepository(VTContext context)
    {
        _context = context; 
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        var users = await _context.Users.ToListAsync();

        return users;
    }
}
