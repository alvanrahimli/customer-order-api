using CustomerOrderApi.Domain.Models;

namespace CustomerOrderApi.Infrastructure.Abstract
{
    public interface IOrderItemRepository : IEntityRepository<OrderItem, int>
    {
        
    }
}