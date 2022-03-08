using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopCostumers.Domain.Commands.Handlers;
using ShopCostumers.Domain.Commands.Requests;
using ShopCostumers.Domain.Commands.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCostumers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public CreateCustomerResponse Create([FromServices] ICreateCustomerHandler handler, [FromBody]CreateCustomerRequest request)
        {
           return handler.Handle(request);
        }
    }
}
