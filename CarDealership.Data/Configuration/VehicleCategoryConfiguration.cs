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
    public class VehicleCategoryConfiguration : IEntityTypeConfiguration<VehicleCategory>
    {
        public void Configure(EntityTypeBuilder<VehicleCategory> builder)
        {
            builder.HasData(GenerateVehicleCategories());
        }

        private List<VehicleCategory> GenerateVehicleCategories()
        {
            List<VehicleCategory> categories = new List<VehicleCategory>()
            {
                new VehicleCategory()
                {
                    Name = "Седан"
                },
                new VehicleCategory()
                {
                    Name = "Комби"
                },
                new VehicleCategory()
                {
                    Name = "Кабрио"
                },
                new VehicleCategory()
                {
                    Name = "Хечбег"
                }, 
                new VehicleCategory()
                {
                    Name = "Ван"
                },
                new VehicleCategory()
                {
                    Name = "Пикап"
                },
                new VehicleCategory()
                {
                    Name = "Купе"
                },
                new VehicleCategory()
                {
                    Name = "Джип"
                },
            };

            return categories;
        }
    }
}
