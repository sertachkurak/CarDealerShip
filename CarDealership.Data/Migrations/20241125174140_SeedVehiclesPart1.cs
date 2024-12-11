using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealership.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedVehiclesPart1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CategoryId", "Cubage", "Doors", "FuelType", "GearBox", "HorsePower", "ImageUrl", "IsDeleted", "LocationId", "Make", "Model", "Price", "PurposeId", "Seats", "TankCapacity", "TypeId", "Year" },
                values: new object[,]
                {
                    { new Guid("09f490ca-6410-4a2c-8c0b-8126deb481d9"), new Guid("4012cbab-8211-4c37-8566-f73f083e999f"), 6000, 4, "Бензин", "Автоматична", 609, "https://a4d540d8508d4f8a94eefc64d221e3d5.objectstore.eu/lot-20087413/1000x0/94a340b554216b7d5753cdc44dc7217c.jpg", false, new Guid("84a3dfe2-4c08-4e18-9156-7452e556c1dd"), "BMW", "760", 180000m, new Guid("b5877ed2-bb7a-4a22-be82-6db9308cd2b7"), 5, 100, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2019" },
                    { new Guid("0af30cc4-cc9f-4ee3-aa86-711f7c30345e"), new Guid("37545039-ea1a-4970-8a41-abe0005291fd"), 5200, 2, "Бензин", "Автоматична", 639, "https://www.astonmartinwashingtondc.comimagetag/3371/3lNew-2022Aston-Martin-DBS-Superleggera-1664901853.jpg", false, new Guid("95d16d5b-0edb-46ed-9abc-822545a05860"), "Aston martin", "DBS", 500000m, new Guid("b5877ed2-bb7a-4a22-be82-6db9308cd2b7"), 4, 120, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2022" },
                    { new Guid("19f498b3-ec25-4a68-a65f-fc6262e11c7b"), new Guid("37545039-ea1a-4970-8a41-abe0005291fd"), 4000, 2, "Бензин", "Автоматична", 549, "https://www.carpixel.netw/3606b3152f8facfae42a639f23b09c95bentleycontinental-gt-s-wallpaperhd-109039.jpg", false, new Guid("48141d40-a443-4edf-aa93-80a12db8690e"), "Bentley", "Continental GT", 470000m, new Guid("b5877ed2-bb7a-4a22-be82-6db9308cd2b7"), 4, 100, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2022" },
                    { new Guid("238de9b6-279e-4488-ae1e-89b0098edccf"), new Guid("4012cbab-8211-4c37-8566-f73f083e999f"), 3000, 4, "Бензин", "Автоматична", 340, "https://a4d540d8508d4f8a94eefc64d221e3d5.objectstore.eu/lot-19801563/1000x0/d00867bc670fa9c6fcae88c376ab6628.jpg", false, new Guid("48141d40-a443-4edf-aa93-80a12db8690e"), "Audi", "A8", 90000m, new Guid("b5877ed2-bb7a-4a22-be82-6db9308cd2b7"), 5, 90, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2018" },
                    { new Guid("427fd628-b2b6-405c-a6fb-bcd500a3ffd9"), new Guid("37545039-ea1a-4970-8a41-abe0005291fd"), 3800, 2, "Бензин", "Автоматична", 560, "https://www.perfectautocollection.com/imagetag/3466/2/l/Used-2014-Porsche-911-Turbo-S-1722623538.jpg", false, new Guid("3cb2b945-5fb2-4489-805e-b879154902a6"), "Porsche", "911 Turbo S", 270000m, new Guid("b5877ed2-bb7a-4a22-be82-6db9308cd2b7"), 4, 80, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2014" },
                    { new Guid("71b3ad65-17cf-48ac-9e67-808b897978a7"), new Guid("247c145d-9b6d-4315-a68a-f8191b687429"), 1600, 4, "Дизел", "Ръчна", 120, "https://static-eu.cargurus.com/images/forsale/2024/09/11/21/37/2018_fiat_talento-pic-8046155731279073145-1024x768.jpeg", false, new Guid("3cb2b945-5fb2-4489-805e-b879154902a6"), "Fiat", "Talento", 18999m, new Guid("661d2044-185a-4911-8864-1285c0638e09"), 3, 70, new Guid("8f40d349-c104-430e-81d4-ab1ba6390187"), "2017" },
                    { new Guid("9a4b8516-7536-4f68-95eb-259354cb47f2"), new Guid("939d5a93-8d55-4ec3-b3ac-39a36cd1ff29"), 4000, 4, "Бензин", "Автоматична", 605, "https://gtspirit.com/wp-content/uploads/2015/05/Audi-RS6-Avant-2.jpg", false, new Guid("84a3dfe2-4c08-4e18-9156-7452e556c1dd"), "Audi", "RS6", 110000m, new Guid("b5877ed2-bb7a-4a22-be82-6db9308cd2b7"), 5, 100, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2016" },
                    { new Guid("abd1d814-d632-4ce7-a367-b0c527fb1941"), new Guid("37545039-ea1a-4970-8a41-abe0005291fd"), 3000, 4, "Дизел", "Автоматична", 250, "https://www.southeastautoshowroom.com/imagetag/1492/mainlUsed-2023Land-/Rover-Defender-110-X-1682620154.jpg", false, new Guid("ae187b67-abd1-4c1a-8590-6a22c6de4b17"), "Land Rover", "Defender", 160000m, new Guid("661d2044-185a-4911-8864-1285c0638e09"), 5, 95, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2023" },
                    { new Guid("d851b2b2-9786-42e3-adab-90c8cb87a138"), new Guid("37545039-ea1a-4970-8a41-abe0005291fd"), 2000, 2, "Бензин", "Автоматична", 299, "https://static.auctionauto.com.ua/images/image.autowini.com/AUTOWINI4/UploadImage/Thumb/202206/20/CI202206200001520806/1655653021563_1024.jpg", false, new Guid("95d16d5b-0edb-46ed-9abc-822545a05860"), "Mercedes-Benz", "S 350", 100000m, new Guid("b5877ed2-bb7a-4a22-be82-6db9308cd2b7"), 4, 70, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2020" },
                    { new Guid("f140489d-c0b6-42a8-a1d5-f5fa76e1e508"), new Guid("4012cbab-8211-4c37-8566-f73f083e999f"), 5000, 4, "Бензин", "Автоматична", 455, "https://editorial.pxcrush.net/carsales/general/editorial/ge5710401472975685544.jpg?width=1024&height=682", false, new Guid("ae187b67-abd1-4c1a-8590-6a22c6de4b17"), "Mercedes-Benz", "S 500", 80000m, new Guid("b5877ed2-bb7a-4a22-be82-6db9308cd2b7"), 5, 90, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2016" }
                });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
