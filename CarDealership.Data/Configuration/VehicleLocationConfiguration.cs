using CarDealership.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealership.Data.Configuration
{
    public class VehicleLocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(GenerateLocation());
        }

        private List<Location> GenerateLocation()
        {
            List<Location> locations = new List<Location>()
            {
                new Location()
                {
                    Name = "София"
                },
                new Location()
                {
                    Name = "Пловдив"
                },
                new Location()
                {
                    Name = "Варна"
                },
                new Location()
                {
                    Name = "Плевен"
                },
                new Location()
                {
                    Name = "Бургас"
                },
            };

            return locations;
        }
    }
}
