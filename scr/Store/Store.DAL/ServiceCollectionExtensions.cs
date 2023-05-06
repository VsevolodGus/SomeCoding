using Microsoft.Extensions.DependencyInjection;
using Store.DAL.MSSQL;
using Store.DAL.PGSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL;
public static class ServiceCollectionExtensions
{

    public static IServiceCollection AddDAL(this IServiceCollection services)
    {

        services.UsePgSqlDatabase();
        //TODO  использование БД
        //services.UseMsSqlDatabase();


        return services;
    }
}
