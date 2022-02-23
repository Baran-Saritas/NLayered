using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess;
using System.Threading.Tasks;
using Core.Domain;

namespace DataAccess
{
    public interface IUnitOfWork
    {
        IEntityRepository<TEntity> GenerateRepository<TEntity>()
            where TEntity : BaseEntity, new();
        Task BeginTransactionAsync();
        Task RollbackTransactionAsync();
        Task CommitTransactionAsync();
    }
}
