using Microsoft.EntityFrameworkCore;
using SapNetClone.Entities.Classes.BaseClasses;

namespace SapNetClone.Application.Abstract.Repositories
{
    public interface IRepository<T> where T : BaseObject
    {
        DbSet<T> DataTable { get; }
    }
}
