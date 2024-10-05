using Microsoft.EntityFrameworkCore;
using Ordering.Domain.Common;

namespace Ordering.Infrastructure.Repositories
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseEntity, IAggregateRoot
    {
        private readonly OrderContext _context;

        protected GenericRepository(OrderContext context)
        {
            _context = context;
        }

        public TEntity Add(TEntity entity)
        {
            return _context.Set<TEntity>().Add(entity).Entity;
        }

        public async Task<TEntity?> FindById(string id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
