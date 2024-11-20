using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealership.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingVehiclesPart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CategoryId", "Cubage", "Doors", "FuelType", "GearBox", "HorsePower", "ImageUrl", "IsDeleted", "LocationId", "Make", "Model", "Price", "PurposeId", "Seats", "TankCapacity", "TypeId", "Year" },
                values: new object[,]
                {
                    { new Guid("2586f04b-e220-460d-b29b-e6503912fe21"), new Guid("a9f48de6-0feb-4b5f-8585-bffac93e5041"), 3000, 4, "Дизел", "Автоматична", 250, "https://www.southeastautoshowroom.com/imagetag/1492/main/lUsed-2023Land-Rover-Defender-110-X-1682620154.jpg", false, new Guid("683f4284-6138-4dce-9191-32206dfd442e"), "Land Rover", "Defender", 160000m, new Guid("545e3752-ee3a-42a4-8ad1-c1250e6ba184"), 5, 95, new Guid("f6fcc477-d738-4077-b0d0-c5f5fcfdbe68"), "2023" },
                    { new Guid("34ba1ea9-ef61-4572-a2df-38953c40a660"), new Guid("8d5dd07e-cefe-45c2-8266-c28946a99400"), 2000, 4, "Бензин", "Автоматична", 210, "https://imgr1.auto-motor-und-sport.de/Audi-A4-Avant-1-8-TFSIreact169Big-/f606376d-384773.jpg", false, new Guid("47c0d9b6-ff78-4c4b-8872-14f12e12f024"), "Audi", "A4", 1100m, new Guid("edd96e69-2979-4813-99c3-5ede5304d595"), 5, 70, new Guid("f6fcc477-d738-4077-b0d0-c5f5fcfdbe68"), "2010" },
                    { new Guid("3a29f8f0-b4c9-43c1-a874-995eef2571de"), new Guid("0e706b47-5378-48e6-b7df-21e2b1d32901"), 2000, 4, "Дизел", "Ръчна", 130, "https://images.clickdealer.co.uk/vehicles/4175/4175102/large2/92193323.jpg", false, new Guid("729897ec-6a17-4851-8831-4d2b2d04f064"), "Ford", "Transit", 27000m, new Guid("545e3752-ee3a-42a4-8ad1-c1250e6ba184"), 3, 90, new Guid("8474c958-2f28-47d2-9878-d7eca96ee0d4"), "2019" },
                    { new Guid("570a87b6-5a67-44b9-a3aa-ae911869bf00"), new Guid("d5a8ece2-9696-42ae-94e5-30319050da93"), 13000, 2, "Дизел", "Автоматична", 480, "https://www.truck1.bg/img/Vlekach_DAF_XF_480_FT_EURO_6_ADR-xxl-8235/8235_5044513319890.jpg", false, new Guid("729897ec-6a17-4851-8831-4d2b2d04f064"), "Daf", "XF 408", 88999m, new Guid("545e3752-ee3a-42a4-8ad1-c1250e6ba184"), 2, 1200, new Guid("372dded3-031b-4892-b74b-7b4853d68603"), "2020" },
                    { new Guid("5b98e28b-20fc-4a25-85c7-e8d437ec42cb"), new Guid("8d5dd07e-cefe-45c2-8266-c28946a99400"), 4000, 4, "Бензин", "Автоматична", 605, "https://gtspirit.com/wp-content/uploads/2015/05/Audi-RS6-Avant-2.jpg", false, new Guid("47c0d9b6-ff78-4c4b-8872-14f12e12f024"), "Audi", "RS6", 110000m, new Guid("5999e3db-7948-47ab-a2b7-2aa0393ad07e"), 5, 100, new Guid("f6fcc477-d738-4077-b0d0-c5f5fcfdbe68"), "2016" },
                    { new Guid("7564cb09-7a00-4910-ae3d-98fb46d104ea"), new Guid("bbcee395-3c50-4b16-8c6b-078997031124"), 4000, 2, "Бензин", "Автоматична", 549, "https://www.carpixel.netw/3606b3152f8facfae42a639f23b09c95bentleycontinental-gt-s-wallpaperhd-109039.jpg", false, new Guid("729897ec-6a17-4851-8831-4d2b2d04f064"), "Bentley", "Continental GT", 470000m, new Guid("5999e3db-7948-47ab-a2b7-2aa0393ad07e"), 4, 100, new Guid("f6fcc477-d738-4077-b0d0-c5f5fcfdbe68"), "2022" },
                    { new Guid("86e4450c-48b7-42f7-8739-e9d1efe04a40"), new Guid("94e34e27-1dbd-4d96-b3f2-7bc799cc2853"), 2200, 4, "Дизел", "Ръчка", 150, "https://abstoragev4.blob.core.windows.net/auctions/39678/cars/medium/39678-1_ex.jpg", false, new Guid("30b08e92-62de-42f7-b345-aca315dfd54a"), "Ford", "Ranger", 27000m, new Guid("e1a23bd8-ca1f-43f1-a73e-63dbd887fc20"), 5, 80, new Guid("f6fcc477-d738-4077-b0d0-c5f5fcfdbe68"), "2012" },
                    { new Guid("c2c44164-8c3f-42a4-bc46-5ecfa68bae6f"), new Guid("e091f5bb-8030-47c1-bf33-4856df0d905e"), 1600, 2, "Дизел", "Ръчна", 92, "https://wallpapers.com/images/hd/caption-stylish-citroen-berlingo-onthe-/open-road-r6rrgptqhdh95zwh.jpg", false, new Guid("729897ec-6a17-4851-8831-4d2b2d04f064"), "Citroen", "Berlingo", 9000m, new Guid("e1a23bd8-ca1f-43f1-a73e-63dbd887fc20"), 2, 60, new Guid("f6fcc477-d738-4077-b0d0-c5f5fcfdbe68"), "2014" },
                    { new Guid("db3b9203-e685-4663-a130-61628aaff828"), new Guid("0e706b47-5378-48e6-b7df-21e2b1d32901"), 1600, 4, "Дизел", "Ръчна", 120, "https://static-eu.cargurus.com/images/forsale/2024/09/11/21/37/2018_fiat_talento-pic-8046155731279073145-1024x768.jpeg", false, new Guid("683f4284-6138-4dce-9191-32206dfd442e"), "Fiat", "Talento", 18999m, new Guid("545e3752-ee3a-42a4-8ad1-c1250e6ba184"), 3, 70, new Guid("8474c958-2f28-47d2-9878-d7eca96ee0d4"), "2017" },
                    { new Guid("decafe98-eea5-4183-a6e6-2f44819364f0"), new Guid("bbcee395-3c50-4b16-8c6b-078997031124"), 5200, 2, "Бензин", "Автоматична", 639, "https://www.astonmartinwashingtondc.comimagetag/3371/3lNew-2022Aston-Martin-DBS-Superleggera-1664901853.jpg", false, new Guid("47c0d9b6-ff78-4c4b-8872-14f12e12f024"), "Aston martin", "DBS", 500000m, new Guid("5999e3db-7948-47ab-a2b7-2aa0393ad07e"), 4, 120, new Guid("f6fcc477-d738-4077-b0d0-c5f5fcfdbe68"), "2022" }
                });

           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
