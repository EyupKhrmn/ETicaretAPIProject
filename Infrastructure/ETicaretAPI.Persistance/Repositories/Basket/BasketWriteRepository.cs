using ETicaretAPI.Application.Repositories.Basket;
using ETicaretAPI.Persistance.Contexts;

namespace ETicaretAPI.Persistance.Repositories.Basket;

public class BasketWriteRepository : WriteRepository<Domain.Entities.Basket>, IBasketWriteREpository
{
    public BasketWriteRepository(ETicaretApÄ±DbContext context) : base(context)
    {
    }
}