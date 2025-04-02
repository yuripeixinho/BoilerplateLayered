using Microsoft.EntityFrameworkCore;
using TF.Core.Domain;

namespace TF.Data.Context;

public class TFContext : DbContext
{
    public TFContext(DbContextOptions<TFContext> options ) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }  
}
