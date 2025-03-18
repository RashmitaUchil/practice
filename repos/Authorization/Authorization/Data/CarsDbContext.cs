using Authorization.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Data
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
