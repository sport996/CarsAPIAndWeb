using WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }

    }
}