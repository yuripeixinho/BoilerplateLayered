using Microsoft.EntityFrameworkCore;
using TF.Data.Context;

namespace TF.WebApi.Configuration;

public static class DatabaseConfig
{
    public static void AddDataBaseConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("TFConnection");
        Console.WriteLine($"Connection String usada: {connectionString}");

        services.
            AddDbContext<TFContext>(options =>
            options.UseSqlServer(connectionString));
    }

    public static void UseDatabaseConfiguration(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
        using var context = serviceScope.ServiceProvider.GetService<TFContext>();

        if (context == null)
            throw new InvalidOperationException("O contexto do banco de dados não pôde ser resolvido. Verifique a injeção de dependência.");
        
       context.Database.Migrate();
    }
}
