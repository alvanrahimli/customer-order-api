using System.Data;
using System.Threading.Tasks;
using CustomerOrderApi.Infrastructure.Abstract;
using CustomerOrderApi.Infrastructure.Concrete;
using CustomerOrderApi.Infrastructure.Data;
using CustomerOrderApi.Infrastructure.UnitOfWork.Abstract;
using Microsoft.EntityFrameworkCore.Storage;

namespace CustomerOrderApi.Infrastructure.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IDbContextTransaction _transaction;

        public ICustomerRepository CustomerRepository => new CustomerRepository(_context);
        public IAddressRepository AddressRepository => new AddressRepository(_context);
        public IOrderRepository OrderRepository { get; }
        public IOrderItemRepository OrderItemRepository { get; }
        public IProductRepository ProductRepository { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            // _transaction = _context.Database.BeginTransaction();
        }
        
        public async Task Commit()
        {
            await _transaction.CommitAsync();
        }

        public async Task Rollback()
        {
            await _transaction.RollbackAsync();
        }
    }
}