using System.Linq.Expressions;

namespace Store.DAL.Interfaces;
public interface IReadonlyRepository<T>
    where T : class
{
    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
    Task<bool> AnyAsync(CancellationToken cancellationToken);

    Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
    Task<T> FirstOrDefaultAsync(CancellationToken cancellationToken);

    Task<T[]> ToArrayAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
    Task<T[]> ToArrayAsync(CancellationToken cancellationToken);

    Task<bool> AllAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);
}
