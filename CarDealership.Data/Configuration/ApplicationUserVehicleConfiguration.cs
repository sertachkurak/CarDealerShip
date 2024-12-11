using CarDealership.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealership.Data.Configuration
{
    public class ApplicationUserVehicleConfiguration : IEntityTypeConfiguration<ApplicationUserVehicle>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserVehicle> builder)
        {
            builder
                .HasKey(um => new { um.ApplicationUserId, um.VehicleId });

            builder
                .HasOne(um => um.Vehicle)
                .WithMany(m => m.VehicleUser)
                .HasForeignKey(um => um.VehicleId);

            builder
                .HasOne(um => um.ApplicationUser)
                .WithMany(u => u.ApplicationUserVehicles)
                .HasForeignKey(um => um.ApplicationUserId);
        }
    }
}
