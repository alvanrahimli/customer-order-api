using CustomerOrderApi.Domain.Models;

namespace CustomerOrderApi.Infrastructure.Abstract
{
    public interface IProductRepository : IEntityRepository<Product, int>
    {
        
    }
}