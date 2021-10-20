using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CustomerOrderApi.Domain.Models;
using CustomerOrderApi.Infrastructure.Abstract;
using CustomerOrderApi.Infrastructure.Data;

namespace CustomerOrderApi.Infrastructure.Concrete
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDbContext _context;

        public AddressRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Address> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Address>> GetAllFilteredAsync(Expression<Func<Address, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Address>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(Address entity)
        {
            throw new NotImplementedException();
        }

        public async Task AddRangeAsync(List<Address> entities)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Address entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteRangeAsync(List<int> keys)
        {
            throw new NotImplementedException();
        }
    }
}