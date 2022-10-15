using Microsoft.EntityFrameworkCore;
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
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=sql.bsite.net\\MSSQL2016;Database=erhanozgan_SAP;User=erhanozgan_SAP;Password=parcalasd1Q;");
    }

    #region DbSet

    public DbSet<User> User { get; set; }
    public DbSet<Product> Product { get; set; }

    #endregion
}