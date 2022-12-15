using Crud_Bus.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud_Bus.Context
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDone> CarsDone { get; set; }
        public DbSet<NewCarDone> NewCarsDone { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
