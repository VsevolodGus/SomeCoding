using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Store.DAL.PGSQL;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection UsePgSqlDatabase(this IServiceCollection services, IConfiguration configuration )
    {
        var connectionStringPG = configuration.GetConnectionString("ConnectionStringPG");
        services.AddScoped<IDbContextConfiguration>(c => new DbContextConfiguration(connectionStringPG));


        return services;
    }
}
