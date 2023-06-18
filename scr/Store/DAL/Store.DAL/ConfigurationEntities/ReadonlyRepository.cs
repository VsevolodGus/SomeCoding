using Microsoft.EntityFrameworkCore;
using Store.DAL.Entities;
using Store.DAL.Interfaces;
using System.Linq.Expressions;

namespace Store.DAL.ConfigurationEntities;
internal class ReadonlyRepository<T> : IReadonlyRepository<T>
    where T : class
{
    private readonly DbSet<T> _dbSet;
    public ReadonlyRepository(DbSet<T> dbSet)
    {
        _dbSet = dbSet;
    }

    public Task<bool> AllAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
    {
        return _dbSet.AllAsync(predicate, cancellationToken);
    }

    public Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
    {
        return _dbSet.AnyAsync(predicate, cancellationToken);
    }

    public Task<bool> AnyAsync(CancellationToken cancellationToken)
    {
        return _dbSet.AnyAsync(cancellationToken);
    }

    public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
    {
        return _dbSet.FirstOrDefaultAsync(predicate, cancellationToken);
    }

    public Task<T> FirstOrDefaultAsync(CancellationToken cancellationToken)
    {
        return _dbSet.FirstOrDefaultAsync(cancellationToken);
    }

    public Task<T[]> ToArrayAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken)
    {
        return _dbSet.Where(predicate).ToArrayAsync(cancellationToken);
    }

    public Task<T[]> ToArrayAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult(Array.Empty<T>());
        //return _dbSet.ToArrayAsync(cancellationToken);
    }
}
