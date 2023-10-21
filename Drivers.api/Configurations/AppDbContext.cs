using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drivers.api.Models;
using Microsoft.EntityFrameworkCore;


namespace Drivers.api.Configurations
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Car> Cars { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Driver>(entity => {
                entity.HasOne(d => d.carOfDriver)
                    .WithOne(c => c.driverOfCar)
                    .HasForeignKey<Driver>(d => d.carId);
            });
        }

    }
}