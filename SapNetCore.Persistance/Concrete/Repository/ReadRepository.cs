using Microsoft.EntityFrameworkCore;
using SapNetClone.Application.Abstract.Repositories;
using SapNetClone.Context;
using SapNetClone.Entities.Classes.BaseClasses;
using System.Linq.Expressions;

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
        return DataTable.Where(expression);
    }
    #region Async functions 
    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
    {
        return await DataTable.FindAsync(expression);
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await DataTable.FindAsync(id);
    }

    #endregion
}