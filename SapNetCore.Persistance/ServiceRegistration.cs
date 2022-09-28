using Microsoft.Extensions.DependencyInjection;
using SapNetClone.Application.Abstract.Repositories.ProductRepository;
using SapNetClone.Application.Abstract.Repositories.UsersRepository;
using SapNetCore.Persistance.Concrete.Repository.ProductRepository;
using SapNetCore.Persistance.Concrete.Repository.UserRepository;

namespace SapNetCore.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
