using System.Linq.Expressions;
using EShop.Application.Entities;

namespace EShop.Application.Repositories;

public interface IGenericRepository<TEntity> where TEntity : Entity
{
    Task<IEnumerable<TEntity>> Get(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        IEnumerable<string>? includeProperties = null);
    Task<TEntity?> GetById(object id);
    Task Create(TEntity entity);
    void Update(TEntity entity);
    Task Delete(object id);
    void Delete(TEntity entity);
    Task<int> Count();
}