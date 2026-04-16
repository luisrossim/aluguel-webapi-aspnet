using Microsoft.EntityFrameworkCore;
using aluguel_webapi.Entities;

namespace aluguel_webapi.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

}
