using CustomerOrderApi.Domain.Models;

namespace CustomerOrderApi.Infrastructure.Abstract
{
    public interface IOrderRepository : IEntityRepository<Order, int>
    {
        
    }
}