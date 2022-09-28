using SapNetClone.Application.Abstract.Repositories.ProductRepository;
using SapNetClone.Context;
using SapNetClone.Entities.Classes.Product;

namespace SapNetCore.Persistance.Concrete.Repository.ProductRepository;

public class ProductWriteRepository : WriteRepository<Product> , IProductWriteRepository
{
    public ProductWriteRepository(DataContext context) : base(context)
    {
        
    }
}