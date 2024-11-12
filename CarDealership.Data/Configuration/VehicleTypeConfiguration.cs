using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealership.Data.Configuration
{
    public class VehicleTypeConfiguration : IEntityTypeConfiguration<VehicleType>
    {
        public void Configure(EntityTypeBuilder<VehicleType> builder)
        {
            builder.HasData(GenerateVehicleType());
        }

        private List<VehicleType> GenerateVehicleType()
        {
            List<VehicleType> types = new List<VehicleType>()
            {
                new VehicleType()
                {
                    Name = "Автомобил"
                },
                new VehicleType()
                {
                    Name = "Камион"
                },
                new VehicleType()
                {
                    Name = "Бус"
                }
            };

            return types;
        }
    }
}
