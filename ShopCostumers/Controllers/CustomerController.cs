using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopCostumers.Domain.Commands.Requests;
using ShopCostumers.Domain.Commands.Responses;
using System.Threading.Tasks;

namespace ShopCostumers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public Task <CreateCustomerResponse> Create([FromServices] IMediator mediator, [FromBody]CreateCustomerRequest request)
        {
           return mediator.Send(request);
        }
    }
}
