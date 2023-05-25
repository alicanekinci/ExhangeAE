using System.Linq.Expressions;
using ExchangeAE.Entities;

namespace ExchangeAE.Core.DataAccess;

public interface IEntityRepository<TEntity> where TEntity : class, IEntity<int>
{
    TEntity Get(Expression<Func<TEntity, bool>> filter);
    IList<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}
