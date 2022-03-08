using ShopCostumers.Domain.Commands.Requests;
using ShopCostumers.Domain.Commands.Responses;

namespace ShopCostumers.Domain.Commands.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}
