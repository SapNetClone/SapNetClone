using SapNetClone.Entities.Classes.BaseClasses;
using System.Linq.Expressions;

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