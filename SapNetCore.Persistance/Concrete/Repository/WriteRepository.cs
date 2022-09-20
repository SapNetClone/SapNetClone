using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SapNetClone.Application.Abstract.Repositories;
using SapNetClone.Context;
using SapNetClone.Entities.Classes.BaseClasses;

namespace SapNetCore.Persistance.Concrete.Repository;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseObject
{
    readonly private DataContext _context;
    public WriteRepository(DataContext context)
    {
        _context = context;
    }
    public DbSet<T> DataTable => _context.Set<T>();

    public bool Remove(T entity)
    {
        EntityEntry<T> entityEntry = DataTable.Remove(entity);
        return entityEntry.State == EntityState.Deleted;
    }

    public bool RemoveRange(List<T> entity)
    {
        DataTable.RemoveRange(entity);
        return true;
    }
    public bool Update(T entity)
    {
        EntityEntry entityEntry = DataTable.Update(entity);  //ilgili veri context üzerinden gelmiyorsa yani tracking edilmiyorsa kullanýlýr. ??
                                                             //await SaveAsync();
        return entityEntry.State == EntityState.Modified;
    }
    public Task<int> SaveAsync()
    => _context.SaveChangesAsync();
    #region Async functions
    public async Task<bool> Remove(int id)
    {
        T modelToDelete = await DataTable.Where(x => x.Id == id).FirstOrDefaultAsync();
        return Remove(modelToDelete);
    }
    public async Task<bool> AddRangeAsync(List<T> entity)
    {
        //foreach (T entry in entity)
        //{
        //    EntityEntry<T> entityEntry = await Table.AddAsync(entry);
        //    entityEntry.State = EntityState.Added;
        //}
        await DataTable.AddRangeAsync(entity);
        return true;
    }
    public async Task<bool> AddAsync(T entity)
    {
        EntityEntry<T> entityEntry = await DataTable.AddAsync(entity);
        return entityEntry.State == EntityState.Added;
    }

    #endregion
}