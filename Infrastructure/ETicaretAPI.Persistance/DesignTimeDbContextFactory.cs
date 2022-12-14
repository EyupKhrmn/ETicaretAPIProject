using ETicaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ETicaretAPI.Persistance;

public class DesignTimeDbContextFActory : IDesignTimeDbContextFactory<ETicaretApÄ±DbContext>
{
    public ETicaretApÄ±DbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ETicaretApÄ±DbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseSqlServer(Configuration.connectionString);
        return new(dbContextOptionsBuilder.Options);
    }
}