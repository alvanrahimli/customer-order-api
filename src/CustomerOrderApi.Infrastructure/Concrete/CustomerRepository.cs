using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CustomerOrderApi.Domain.Models;
using CustomerOrderApi.Infrastructure.Abstract;
using CustomerOrderApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CustomerOrderApi.Infrastructure.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<Customer> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetAllFilteredAsync(Expression<Func<Customer, bool>> predicate)
        {
            return await _context.Customers.Where(predicate).ToListAsync();
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task AddAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public async Task AddRangeAsync(List<Customer> entities)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Customer entity)
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