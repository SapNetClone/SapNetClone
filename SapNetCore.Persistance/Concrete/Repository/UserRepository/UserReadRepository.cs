using SapNetClone.Application.Abstract.Repositories.UsersRepository;
using SapNetClone.Context;
using SapNetClone.Entities.Classes.UsersClasses;

namespace SapNetCore.Persistance.Concrete.Repository.UserRepository;

public class UserReadRepository : ReadRepository<User> , IUserReadRepository
{
   
    public UserReadRepository(DataContext context) : base(context)
    {

       
    }
}