using System.Linq.Expressions;

namespace Core.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<int> CountAsync(Expression<Func<TEntity, bool>> filter = null, CancellationToken cancellationToken = default);

        Task<bool> AnyAsync(
            Expression<Func<TEntity, bool>> filter = null,
            CancellationToken cancellationToken = default
        );

        Task<IEnumerable<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            CancellationToken cancellationToken = default
        );
        Task<IEnumerable<TResult>> GetAndSelectAsync<TResult>(
            Expression<Func<TEntity, TResult>> selector,
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            CancellationToken cancellationToken = default);


        ValueTask<TEntity> SingleOrDefaultAsync<TKey>(TKey id);
        Task<TEntity> SingleOrDefaultAndSelectAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default
            );
        Task<TResult> SingleOrDefaultAndSelectAsync<TResult>(
            Expression<Func<TEntity, TResult>> selector,
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default);


        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);


        void Remove(TEntity entity);
        void Remove<TKey>(TKey id);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
