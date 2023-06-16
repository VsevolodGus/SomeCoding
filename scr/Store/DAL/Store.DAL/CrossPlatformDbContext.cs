using Microsoft.EntityFrameworkCore;

namespace Store.DAL;

internal class CrossPlatformDbContext : DbContext
{
    private readonly IDbContextModelBuilder _modelBuilder;
    private readonly IDbContextConfiguration _configuration;
    public CrossPlatformDbContext( IDbContextModelBuilder modelBuilder
        , IDbContextConfiguration configuration)
    {
        _modelBuilder = modelBuilder;
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        _configuration.Configure(optionsBuilder); 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _modelBuilder.Build(modelBuilder);
    }
}