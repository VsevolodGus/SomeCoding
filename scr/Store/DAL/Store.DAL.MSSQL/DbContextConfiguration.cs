using Microsoft.EntityFrameworkCore;

namespace Store.DAL.MSSQL;
internal class DbContextConfiguration : IDbContextConfiguration
{
    private readonly string _connectionString;

    public DbContextConfiguration(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void Configure(DbContextOptionsBuilder dbContextOptionsBuilder)
    {
        dbContextOptionsBuilder.UseSqlServer(_connectionString)
            .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Error)
            .EnableDetailedErrors();
    }
}
