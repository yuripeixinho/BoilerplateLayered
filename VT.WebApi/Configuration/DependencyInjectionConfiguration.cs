using VT.Data.Repository;
using VT.Manager.Implementation;
using VT.Manager.Interfaces.Manager;
using VT.Manager.Interfaces.Repositories;

namespace VT.WebApi.Configuration;

public static class DependencyInjectionConfiguration
{
    public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<IUserManager, UserManager>();
    }
}
