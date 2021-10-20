using CustomerOrderApi.Domain.Models;

namespace CustomerOrderApi.Infrastructure.Abstract
{
    public interface IAddressRepository : IEntityRepository<Address, int>
    {
        
    }
}