using SapNetClone.Entities.Classes.BaseClasses;


namespace SapNetClone.Application.Abstract.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseObject
    {

    }
}
