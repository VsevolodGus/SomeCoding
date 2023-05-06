using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Store.DAL.MSSQL;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection UseMsSqlDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionStringMS = configuration.GetConnectionString("ConnectionStringMS");
        services.AddScoped<IDbContextConfiguration>(c => new DbContextConfiguration(connectionStringMS));


        return services;
    }
}
