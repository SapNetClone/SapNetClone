using Microsoft.EntityFrameworkCore;
using SapNetClone.Entities.Classes.BaseClasses;
using SapNetClone.Entities.Classes.Product;
using SapNetClone.Entities.Classes.UsersClasses;

namespace SapNetClone.Context;

public class DataContext : DbContext
{
    public DataContext()
    {
        
    }
    
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //    optionsBuilder.UseSqlServer("Server=TEDESCO420\\SQL2019;Database=SAPNet;User Id=sa;Password=qwerr112358;");
    //}

    //TODO ANLA
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var data = ChangeTracker.Entries<BaseObject>();
        foreach (var entry in data)
        {
            _ = entry.State switch
            {
                EntityState.Added => entry.Entity.CreatedDate = DateTime.Now,
                EntityState.Modified => entry.Entity.LastModifiedOn = DateTime.Now,
                _ => DateTime.Now
            };
        }
       return await base.SaveChangesAsync(cancellationToken);
    }

    #region DbSet

    public DbSet<User> User { get; set; }
    public DbSet<Product> Product { get; set; }

    #endregion
}