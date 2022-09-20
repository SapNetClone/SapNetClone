using Microsoft.EntityFrameworkCore;
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
    
    

    #region DbSet

    public DbSet<User> User { get; set; }

    #endregion
}