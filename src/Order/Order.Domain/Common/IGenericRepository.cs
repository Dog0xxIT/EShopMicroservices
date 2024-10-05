using System.Threading.Tasks;

namespace Ordering.Domain.Common
{
    public interface IGenericRepository<TEntity> where TEntity : class, IAggregateRoot
    {
        TEntity Add(TEntity entity);
        Task<TEntity?> FindById(string id);
        TEntity Update(TEntity entity);
    }
}
