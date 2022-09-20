using SapNetClone.Application.Abstract.Repositories.UsersRepository;
using SapNetClone.Context;
using SapNetClone.Entities.Classes.UsersClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapNetCore.Persistance.Concrete.Repository.UserRepository
{
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {        public UserWriteRepository(DataContext context) : base(context)
        {

        }
    }
}
