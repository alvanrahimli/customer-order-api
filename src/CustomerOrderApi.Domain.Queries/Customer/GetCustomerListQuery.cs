using System.Collections.Generic;
using MediatR;

namespace CustomerOrderApi.Domain.Queries.Customer
{
    public record GetCustomerListQuery(int Skip, int Take) : IRequest<List<Models.Customer>>;
}