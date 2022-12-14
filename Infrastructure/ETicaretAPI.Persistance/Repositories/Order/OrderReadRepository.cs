using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistance.Contexts;

namespace ETicaretAPI.Persistance.Repositories.Order;

public class OrderReadRepository : ReadRepository<Domain.Entities.Order>, IOrderReadRepository
{
    public OrderReadRepository(ETicaretApÄ±DbContext context) : base(context)
    {
    }
}