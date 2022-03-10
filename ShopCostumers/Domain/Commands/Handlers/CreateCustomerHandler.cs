using MediatR;
using ShopCostumers.Domain.Commands.Requests;
using ShopCostumers.Domain.Commands.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ShopCostumers.Domain.Commands.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //Verify if customer included on data base
            //Validate the data
            //Insert the customer
            //Send email of welcome
            
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Welington Luis Dias",
                Email = "welin7uelf@gmail.com",
                CreatedDate = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
