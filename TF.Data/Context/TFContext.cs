using Microsoft.EntityFrameworkCore;
using TF.Core.Domain;
using TF.Data.Mappings;

namespace TF.Data.Context;

public class TFContext : DbContext
{
    public TFContext(DbContextOptions<TFContext> options ) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserMapping());

        base.OnModelCreating(modelBuilder);
    }
}
