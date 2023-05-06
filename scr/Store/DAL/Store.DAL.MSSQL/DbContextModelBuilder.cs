using Microsoft.EntityFrameworkCore;

namespace Store.DAL.MSSQL;
internal class DbContextModelBuilder
{
    public void Build(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
