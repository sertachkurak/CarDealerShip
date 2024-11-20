using CarDealership.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Data
{
    using Models;
    using Configuration;
    public class DealershipDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {

        public DealershipDbContext()
        {
            
        }


        public DealershipDbContext(DbContextOptions<DealershipDbContext> options)
                :base(options)
        {
            
        }

        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;
        public virtual DbSet<VehicleCategory> VehiclesCategories { get; set; } = null!;
        public virtual DbSet<VehicleType> VehiclesTypes { get; set; } = null!;
        public virtual DbSet<VehiclePurpose> VehiclesPurposes { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VehicleCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleTypeConfiguration());
            modelBuilder.ApplyConfiguration(new VehiclePurposeConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleLocationConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleConfiguration());

            base.OnModelCreating(modelBuilder);
        } 
    }
}
