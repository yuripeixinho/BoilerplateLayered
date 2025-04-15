using TF.Data.Repository;
using TF.Manager.Implementation;
using TF.Manager.Interfaces.Manager;
using TF.Manager.Interfaces.Repositories;

namespace TF.WebApi.Configuration;

public static class DependencyInjectionConfiguration
{
    public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<IUserManager, UserManager>();
    }
}
