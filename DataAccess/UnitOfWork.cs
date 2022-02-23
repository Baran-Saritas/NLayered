using Core.DataAccess;
using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork   
    {
        private readonly LibraryContext _context;
        public UnitOfWork(LibraryContext context)
        {
            _context = context;
        }

        public async Task BeginTransactionAsync()
        {
            await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            await _context.Database.CommitTransactionAsync();
        }

        public IEntityRepository<TEntity> GenerateRepository<TEntity>() where TEntity : BaseEntity, new()
        {
            return new EfEntitiyRepositoryBase<TEntity, LibraryContext>(_context);
        }

        public async Task RollbackTransactionAsync()
        {
            await _context.Database.RollbackTransactionAsync();
        }
    }
}
