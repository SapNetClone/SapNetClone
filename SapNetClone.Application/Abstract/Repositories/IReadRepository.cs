using SapNetClone.Entities.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SapNetClone.Application.Abstract.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseObject
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(int id);
    }
}