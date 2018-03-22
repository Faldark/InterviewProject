using System;
using Microsoft.EntityFrameworkCore;
using TempProject.Data.Entities.Abstract;

namespace TempProject.Data.Abstract
{
    public interface IRepositoryFactory
    {
        IRepository<TKey, TEntity> CreateRepository<TKey, TEntity>(DbContext context)
            where TKey : IComparable
            where TEntity : BaseEntity<TKey>;
    }
}
