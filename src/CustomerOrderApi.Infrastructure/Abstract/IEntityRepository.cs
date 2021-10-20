using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CustomerOrderApi.Domain.Models;

namespace CustomerOrderApi.Infrastructure.Abstract
{
    public interface IEntityRepository<TEntity, TKey> where TEntity : BaseModel<TKey>
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllFilteredAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAllAsync();

        Task AddAsync(TEntity entity);
        Task AddRangeAsync(List<TEntity> entities);

        Task UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(TKey key);
        Task<bool> DeleteRangeAsync(List<TKey> keys);
    }
}