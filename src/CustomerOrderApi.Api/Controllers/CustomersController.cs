using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerOrderApi.Domain.Models;
using CustomerOrderApi.Domain.Queries.Customer;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CustomerOrderApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustomers(int skip, int take)
        {
            return await _mediator.Send(new GetCustomerListQuery(skip, take));
        }
    }
}