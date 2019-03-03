using System.Linq;
using System.Threading.Tasks;

namespace DangEasy.Interfaces.Database
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(object id);

        Task<int> CountAsync();
        Task<int> CountAsync(string sqlQuery);

        Task<IQueryable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(object id);

        Task<TEntity> FirstOrDefaultAsync(string sqlQuery);
        Task<IQueryable<TEntity>> QueryAsync(string sqlQuery);
    }
}
