using CustomerOrderApi.Domain.Models;

namespace CustomerOrderApi.Infrastructure.Abstract
{
    public interface ICustomerRepository : IEntityRepository<Customer, int>
    {
        
    }
}