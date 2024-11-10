using CarDealership.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Data
{
    public class DealershipDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {

        public DealershipDbContext()
        {
            
        }


        public DealershipDbContext(DbContextOptions options)
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
            base.OnModelCreating(modelBuilder);
        } 
    }
}
