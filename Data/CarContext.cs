using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Data
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<EngineType> EngineType { get; set; }
        public CarContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Engine>().HasOne(e => e.Car).WithOne(c => c.Engine)
                .HasForeignKey<Engine>("CarId");
        }
    }
}
