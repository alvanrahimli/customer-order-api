using System.Threading.Tasks;
using CustomerOrderApi.Infrastructure.Abstract;

namespace CustomerOrderApi.Infrastructure.UnitOfWork.Abstract
{
    public interface IUnitOfWork
    {
        public ICustomerRepository CustomerRepository { get; }
        public IAddressRepository AddressRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public IOrderItemRepository OrderItemRepository { get; }
        public IProductRepository ProductRepository { get; }

        Task Commit();
        Task Rollback();
    }
}