using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Store.DAL.ConfigurationEntities;
using Store.DAL.Entities;
using Store.DAL.Interfaces;

namespace Store.DAL;
public static class ServiceCollectionExtensions
{

    public static IServiceCollection AddDAL(this IServiceCollection services)
    {
        services.AddDbSet();
        services.AddScoped(typeof(IReadonlyRepository<>), typeof(ReadonlyRepository<>));
        return services;
    }

    private static IServiceCollection AddDbSet(this IServiceCollection services)
    {
        var setMethod = typeof(DbContext).GetMethod(nameof(DbContext.Set), Array.Empty<Type>());

        foreach (var type in EntityTypes)
        {
            var genericSet = setMethod.MakeGenericMethod(type);
            services.AddScoped(
                typeof(DbSet<>).MakeGenericType(type)
                , c => genericSet.Invoke(c.GetService<CrossPlatformDbContext>(), Array.Empty<object>()));
        }

        return services;
    }

    /// <summary>
    /// все типы Entities
    /// </summary>
    private static IEnumerable<Type> EntityTypes
        => typeof(User).Assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract)
                .Where(t => t.Namespace.Contains(typeof(User).Namespace))
                .ToArray();


}
