using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using CarDealerShip.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarDealerShip.Data
{
    public class DealerShipDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {

        public DealerShipDbContext()
        {
            
        }


        public DealerShipDbContext(DbContextOptions options)
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
