using System.Linq.Expressions;

namespace Store.DAL.Interfaces;
public interface IRepository<T> : IReadonlyRepository<T> 
    where T : class
{
    Task Delete(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken);

    Task AddAsync(T entity, CancellationToken cancellationToken);
}
