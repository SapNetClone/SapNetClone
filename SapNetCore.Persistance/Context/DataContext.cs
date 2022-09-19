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
    
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    base.OnConfiguring(optionsBuilder);
    //    optionsBuilder.UseSqlServer("Server=TEDESCO420\\SQL2019;Database=SAPNet;User Id=sa;Password=qwerr112358;");
    //}

    #region DbSet

    public DbSet<User> User { get; set; }

    #endregion
}