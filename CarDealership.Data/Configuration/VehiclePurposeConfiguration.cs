
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
    public class VehiclePurposeConfiguration : IEntityTypeConfiguration<VehiclePurpose>
    {
        public void Configure(EntityTypeBuilder<VehiclePurpose> builder)
        {
            builder.HasData(GeneratePurpose());
        }

        private List<VehiclePurpose> GeneratePurpose()
        {
            List<VehiclePurpose> purposes = new List<VehiclePurpose>()
            {

                new VehiclePurpose()
                {
                    Name = "Икономичен"
                },

                new VehiclePurpose()
                {
                    Name = "Икономичен Комби"
                },

                new VehiclePurpose()
                {
                    Name = "Компактен"
                },

                new VehiclePurpose()
                {
                    Name = "Стандартен"
                },

                new VehiclePurpose()
                {
                    Name = "Стандартен Комби"
                },

                new VehiclePurpose()
                {
                    Name = "Голям"
                },

                new VehiclePurpose()
                {
                    Name = "Луксозен"
                }
            };
            return purposes;
        }
    }
}

