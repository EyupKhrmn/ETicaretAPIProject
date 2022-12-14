using ETicaretAPI.Application.Repositories.Basket;
using ETicaretAPI.Persistance.Contexts;

namespace ETicaretAPI.Persistance.Repositories.Basket;

public class BasketReadRepository : ReadRepository<Domain.Entities.Basket>, IBasketReadRepository
{
    public BasketReadRepository(ETicaretApÄ±DbContext context) : base(context)
    {
    }
}