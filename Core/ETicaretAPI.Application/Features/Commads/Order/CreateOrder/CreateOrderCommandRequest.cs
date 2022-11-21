using MediatR;

namespace ETicaretAPI.Application.Features.Commads.Order.CreateOrder;

public class CreateOrderCommandRequest : IRequest<CreateOrderCommandResponse>
{
    public string Description { get; set; }
    public string Address { get; set; }
}