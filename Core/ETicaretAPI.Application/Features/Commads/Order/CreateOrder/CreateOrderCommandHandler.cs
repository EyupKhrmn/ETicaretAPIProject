using ETicaretAPI.Application.Abstraction.Hubs;
using ETicaretAPI.Application.Abstraction.Services;
using ETicaretAPI.Application.Repositories;
using MediatR;

namespace ETicaretAPI.Application.Features.Commads.Order.CreateOrder;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest,CreateOrderCommandResponse>
{
    private readonly IOrderService _orderService;
    private readonly IBasketService _basketService;
    private readonly IOrderHubService _orderHubService;

    public CreateOrderCommandHandler(IOrderService orderService, IProductReadRepository productReadRepository, IBasketService basketService, IOrderHubService orderHubService)
    {
        _orderService = orderService;
        _basketService = basketService;
        _orderHubService = orderHubService;
    }

    public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
    {
        await _orderService.CreateOrderAsync(new()
        {
            Address = request.Address,
            Description = request.Description,
            BasketId = _basketService.GetUserActiveBasket?.Id.ToString()
        });

        await _orderHubService.OrderAddedMessageAsync("Yeni bir sipariş oluşturuldu !");

        return new();
    }
}