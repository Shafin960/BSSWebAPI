using Core;
using Core.IRepositories;
using Data.Respositories;

namespace Data
{
    public sealed class UnitOfWork<TEntity> : IUnitOfWork<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        private Repository<TEntity> _repository;

        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IRepository<TEntity> Entity => _repository ??= new Repository<TEntity>(_context);

        public int Commit() => _context.SaveChanges();
        public async Task<int> CommitAsync() => await _context.SaveChangesAsync();

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
