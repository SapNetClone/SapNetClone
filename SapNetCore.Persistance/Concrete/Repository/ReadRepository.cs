using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SapNetClone.Application.Abstract.Repositories;
using SapNetClone.DataAccess.Context;
using SapNetClone.Entities.Classes.BaseClasses;

namespace SapNetCore.Persistance.Concrete.Repository;

public class ReadRepository<T> : IReadRepository<T> where T : BaseObject
{
    private readonly DataContext _context;

    public ReadRepository(DataContext context)
    {
        _context = context;
    }

    public DbSet<T> DataTable => _context.Set<T>();

    public IQueryable<T> GetAll()
    {
        var data = DataTable.AsQueryable();
        return data;

    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    #region Async

    #endregion
}