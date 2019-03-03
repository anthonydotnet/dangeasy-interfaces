using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DangEasy.Interfaces.Database
{
    public interface IRepositoryExtended<TId, TEntity> : IRepository<TId, TEntity>
    where TId : class
    where TEntity : class
    {
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> FirstOrDefaultAsync(Func<TEntity, bool> predicate);

        Task<IQueryable<TEntity>> QueryAsync(Func<TEntity, bool> predicate);

        Task<IQueryable<TEntity>> QueryByStoredProcedureAsync(string sprocName, params object[] parameters);
        Task<TResult> ExecuteStoredProcedureAsync<TResult>(string sprocName, params object[] parameters);
    }
}
