using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealership.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingVehiclesPart1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CategoryId", "Cubage", "Doors", "FuelType", "GearBox", "HorsePower", "ImageUrl", "IsDeleted", "LocationId", "Make", "Model", "Price", "PurposeId", "Seats", "TankCapacity", "TypeId", "Year" },
                values: new object[,]
                {
                    { new Guid("2ca127ec-4df8-4091-bd25-de8a6bd43d0e"), new Guid("89253114-1117-481a-94c8-c93e798c73f3"), 6000, 4, "Бензин", "Автоматична", 609, "https://a4d540d8508d4f8a94eefc64d221e3d5.objectstore.eu/lot-20087413/1000x0/94a340b554216b7d5753cdc44dc7217c.jpg", false, new Guid("729897ec-6a17-4851-8831-4d2b2d04f064"), "BMW", "760", 180000m, new Guid("5999e3db-7948-47ab-a2b7-2aa0393ad07e"), 5, 100, new Guid("f6fcc477-d738-4077-b0d0-c5f5fcfdbe68"), "2019" },
                    { new Guid("967be653-60f4-4b13-9935-f82310868122"), new Guid("89253114-1117-481a-94c8-c93e798c73f3"), 3000, 4, "Бензин", "Автоматична", 340, "https://a4d540d8508d4f8a94eefc64d221e3d5.objectstore.eu/ lot-19801563/1000x0/d00867bc670fa9c6fcae88c376ab6628.jpg", false, new Guid("928c42ce-f6cf-4a56-8eb0-08d9bd65f99a"), "Audi", "A8", 90000m, new Guid("5999e3db-7948-47ab-a2b7-2aa0393ad07e"), 5, 90, new Guid("f6fcc477-d738-4077-b0d0-c5f5fcfdbe68"), "2018" },
                    { new Guid("9edcbb44-6daf-4954-8652-9a83c5cd3c10"), new Guid("bbcee395-3c50-4b16-8c6b-078997031124"), 3800, 2, "Бензин", "Автоматична", 560, "https://www.perfectautocollection.com/imagetag/3466/2/l/Used-2014-  Porsche-911-Turbo-S-1722623538.jpg", false, new Guid("30b08e92-62de-42f7-b345-aca315dfd54a"), "Porsche", "911 Turbo S", 270000m, new Guid("5999e3db-7948-47ab-a2b7-2aa0393ad07e"), 4, 80, new Guid("f6fcc477-d738-4077-b0d0-c5f5fcfdbe68"), "2014" },
                    { new Guid("bc2d4817-2704-46c9-b7e0-91e40e64064b"), new Guid("89253114-1117-481a-94c8-c93e798c73f3"), 5000, 4, "Бензин", "Автоматична", 455, "https://editorial.pxcrush.net/carsales/general/editorial/ge5710401472975685544.jpg?width=1024&height=682", false, new Guid("30b08e92-62de-42f7-b345-aca315dfd54a"), "Mercedes-Benz", "S 500", 80000m, new Guid("5999e3db-7948-47ab-a2b7-2aa0393ad07e"), 5, 90, new Guid("f6fcc477-d738-4077-b0d0-c5f5fcfdbe68"), "2016" },
                    { new Guid("e21b23e0-7f17-40c1-94ad-2d578bbc9245"), new Guid("7ae247d2-af02-4d12-8531-aec70481ec82"), 2000, 2, "Бензин", "Автоматична", 299, "https://www.inghamdriven.nz/wp-content/files/stockCNM/8098/20538_01.jpg?/  width=2048&optimize=medium", false, new Guid("47c0d9b6-ff78-4c4b-8872-14f12e12f024"), "Mercedes-Benz", "S 350", 100000m, new Guid("5999e3db-7948-47ab-a2b7-2aa0393ad07e"), 4, 70, new Guid("f6fcc477-d738-4077-b0d0-c5f5fcfdbe68"), "2020" }
                });

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
