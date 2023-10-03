using Microsoft.EntityFrameworkCore;

namespace BarakatTop.Data.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {    }
}
