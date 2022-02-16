using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntitiyRepository<TEntity> where TEntity : BaseEntity,new()
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(Guid id, TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task DeleteByIdAsync(Guid id);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task<ICollection<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate = null);

    }
}
