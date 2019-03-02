using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DangEasy.CosmosDb.Interfaces
{
    public interface IRepository<TId, TEntity>
    where TId : class
    where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(TId id);

        Task<int> CountAsync();
        Task<int> CountAsync(string sqlQuery);

        Task<IQueryable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TId id);

        Task<TEntity> FirstOrDefaultAsync(string sqlQuery);
        Task<IQueryable<TEntity>> QueryAsync(string sqlQuery);
    }
}
