using SapNetClone.Application.Abstract.Repositories.ProductRepository;
using SapNetClone.Context;
using SapNetClone.Entities.Classes.Product;

namespace SapNetCore.Persistance.Concrete.Repository.ProductRepository;

public class ProductReadRepository : ReadRepository<Product> , IProductReadRepository
{
    public ProductReadRepository(DataContext context) : base(context)
    {
            
    }
}