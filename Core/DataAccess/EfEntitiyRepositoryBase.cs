using Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public class EfEntitiyRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : BaseEntity, new()
        where TContext : DbContext
    {
        protected readonly TContext context;
        protected readonly DbSet<TEntity> DbSet;

        public EfEntitiyRepositoryBase(TContext _context)
        {
            context = _context;
            DbSet = context.Set<TEntity>(); // DbSeti vericek metod
        }


        public async Task AddAsync(TEntity entity)
        {
           await DbSet.AddAsync(entity);
           await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            DbSet.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            var entity = DbSet.Find(id);
            await DeleteAsync(entity);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.Where(predicate).FirstOrDefaultAsync();
        }

        public async Task<ICollection<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            if(predicate != null)
            {
                return await DbSet.Where(predicate).ToListAsync();
            }
            return await DbSet.ToListAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            DbSet.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
