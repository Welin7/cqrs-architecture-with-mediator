using ShopCostumers.Domain.Commands.Requests;
using ShopCostumers.Domain.Commands.Responses;
using System;

namespace ShopCostumers.Domain.Commands.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            //Verify if customer included on data base
            //Validate the data
            //Insert the customer
            //Send email of welcome
            
            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Welington Luis Dias",
                Email = "welin7uelf@gmail.com",
                CreatedDate = DateTime.Now
            };
        }
    }
}
