using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
}
