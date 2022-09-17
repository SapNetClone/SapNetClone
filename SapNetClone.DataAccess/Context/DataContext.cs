using Microsoft.EntityFrameworkCore;

namespace SapNetClone.DataAccess.Context;

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
        optionsBuilder.UseSqlServer("Server=localhost;Database=SapNetClone;User=sa;Password=MyPass@word;");
    }

    #region DbSet

    

    #endregion
}