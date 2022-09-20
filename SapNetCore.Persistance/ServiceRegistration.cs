using Microsoft.Extensions.DependencyInjection;
using SapNetClone.Application.Abstract.Repositories.UsersRepository;
using SapNetCore.Persistance.Concrete.Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapNetCore.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
            //services.AddScoped<IUserReadRepository, UserReadRepository>();
        }
    }
}
