using System.Linq.Expressions;
using Core.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Data.Respositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            this.Context = context;
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> filter = null, CancellationToken cancellationToken = default)
        {
            return filter != null 
                ? await Context.Set<TEntity>().AsNoTracking().CountAsync(filter, cancellationToken)
                : await Context.Set<TEntity>().AsNoTracking().CountAsync(cancellationToken);
        }

        public Task<bool> AnyAsync(
            Expression<Func<TEntity, bool>> filter = null,
            CancellationToken cancellationToken = default)
        {
            return filter != null
                ? Context.Set<TEntity>().AnyAsync(filter, cancellationToken)
                : Context.Set<TEntity>().AnyAsync(cancellationToken);
        }

        public ValueTask<TEntity> SingleOrDefaultAsync<TKey>(TKey id)
        {
            return Context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> SingleOrDefaultAsync(
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default
            )
        {
            return await Context.Set<TEntity>()
                .AsNoTracking()
                .SingleOrDefaultAsync(predicate, cancellationToken);
        }


        public async Task<TResult> SingleOrDefaultAndSelectAsync<TResult>(
            Expression<Func<TEntity, TResult>> selector,
            Expression<Func<TEntity, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return await Context.Set<TEntity>()
                .AsNoTracking()
                .Where(predicate)
                .Select(selector)
                .SingleOrDefaultAsync(cancellationToken);
        }


        public async Task<IEnumerable<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> query = Context.Set<TEntity>().AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return await query.ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<TResult>> GetAndSelectAsync<TResult>(
            Expression<Func<TEntity, TResult>> selector,
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            CancellationToken cancellationToken = default)
        {

            IQueryable<TEntity> query = Context.Set<TEntity>().AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return await query.Select(selector).ToListAsync(cancellationToken);
        }

        public async Task AddAsync(TEntity entity)
        {
            await Context.Set<TEntity>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await Context.Set<TEntity>().AddRangeAsync(entities);
        }


        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void Remove<TKey>(TKey id)
        {
            TEntity entity = Context.Set<TEntity>().Find(id);
            Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
