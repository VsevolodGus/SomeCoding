using Microsoft.EntityFrameworkCore;

namespace Store.DAL;

public interface IDbContextModelBuilder
{
    void Build(ModelBuilder modelBuilder);
}
