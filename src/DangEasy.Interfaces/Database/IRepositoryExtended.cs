using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DangEasy.Interfaces.Database
{
    public interface IRepositoryExtended<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> FirstOrDefaultAsync(Func<TEntity, bool> predicate);

        Task<IQueryable<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
