using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CustomerOrderApi.Domain.Queries.Customer;
using CustomerOrderApi.Infrastructure.UnitOfWork.Abstract;
using MediatR;

namespace CustomerOrderApi.Application.Handlers.Customer.Command
{
    public class GetCustomerListHandler : IRequestHandler<GetCustomerListQuery, List<Domain.Models.Customer>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetCustomerListHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<List<Domain.Models.Customer>> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
        {
            var customerList = await _unitOfWork.CustomerRepository.GetAllAsync();
            return customerList;
        }
    }
}