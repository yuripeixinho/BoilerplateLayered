using Microsoft.EntityFrameworkCore;
using VT.Core.Domain;
using VT.Data.Mappings;

namespace VT.Data.Context;

public class VTContext : DbContext
{
    public VTContext(DbContextOptions<VTContext> options ) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserMapping());

        base.OnModelCreating(modelBuilder);
    }
}
