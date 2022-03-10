using MediatR;
using ShopCostumers.Domain.Commands.Responses;

namespace ShopCostumers.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public  string Email { get; set; }
    }
}
