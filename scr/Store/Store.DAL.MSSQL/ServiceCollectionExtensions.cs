using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL.MSSQL;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection UseMsSqlDatabase(this IServiceCollection services)
    {



        return services;
    }
}
