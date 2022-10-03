using ETicaretAPI.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}