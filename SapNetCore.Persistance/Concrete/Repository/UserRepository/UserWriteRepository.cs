using SapNetClone.Application.Abstract.Repositories.UsersRepository;
using SapNetClone.Context;
using SapNetClone.Entities.Classes.UsersClasses;

namespace SapNetCore.Persistance.Concrete.Repository.UserRepository
{
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(DataContext context) : base(context)
        {
        }
    }
}
