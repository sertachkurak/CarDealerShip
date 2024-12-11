using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealership.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedVehiclesPart3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CategoryId", "Cubage", "Doors", "FuelType", "GearBox", "HorsePower", "ImageUrl", "IsDeleted", "LocationId", "Make", "Model", "Price", "PurposeId", "Seats", "TankCapacity", "TypeId", "Year" },
                values: new object[,]
                {
                    { new Guid("07a52dd4-ba04-448d-80b9-0730a0716a24"), new Guid("2fc4c7e6-cad0-4190-95b5-78a7420a1631"), 1500, 4, "Дизел", "Автоматична", 116, "https://www.carpixel.net/w/a38025585b428caf0a5e472b1da228bb/minicooper-/s-countryman-car-wallpaper-101089.jpg", false, new Guid("48141d40-a443-4edf-aa93-80a12db8690e"), "Mini", "Countryman", 18000m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 50, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2020" },
                    { new Guid("09ce8f2c-f974-4e36-8093-ce3aa7376cf2"), new Guid("4012cbab-8211-4c37-8566-f73f083e999f"), 4000, 4, "Дизел", "Автоматична", 400, "https://www.sherifo.lt/_next/image?url=https%3A%2F%2Fproduction-carloading-api-media.s3.amazonaws.com%2Flot_image%/2F1_S1ptd2M.png.1920x1080_q85.png&w=3840&q=75", false, new Guid("3cb2b945-5fb2-4489-805e-b879154902a6"), "BMW", "750", 90000m, new Guid("b5877ed2-bb7a-4a22-be82-6db9308cd2b7"), 5, 80, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2019" },
                    { new Guid("194ae085-cc33-46c6-923e-c44a5e14d4df"), new Guid("2fc4c7e6-cad0-4190-95b5-78a7420a1631"), 3000, 4, "Дизел", "Автоматична", 286, "https://media.ed.edmunds-media.com/audi/q7/2018/oem/2018_audi_q7_4dr-suv_30t-prestige-quattro_fq_oem_1_1600.jpg", false, new Guid("95d16d5b-0edb-46ed-9abc-822545a05860"), "Audi", "Q7", 50000m, new Guid("b5877ed2-bb7a-4a22-be82-6db9308cd2b7"), 5, 75, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2018" },
                    { new Guid("204e50c5-56b3-492d-bdcb-e0f4e7cc3e93"), new Guid("5e2e101c-27c9-4b94-b2e8-8f2154a4389b"), 13000, 2, "Дизел", "Автоматична", 480, "https://d2e5b8shawuel2.cloudfront.net/vehicle/304240/hlv/original.jpg", false, new Guid("3cb2b945-5fb2-4489-805e-b879154902a6"), "Daf", "XF 480", 85000m, new Guid("661d2044-185a-4911-8864-1285c0638e09"), 2, 1100, new Guid("f7fa7488-e482-493d-a27c-1f1a7d38f79b"), "2020" },
                    { new Guid("3c3f2cb0-fb06-4616-8396-3aad20b6d7a6"), new Guid("939d5a93-8d55-4ec3-b3ac-39a36cd1ff29"), 2000, 4, "Дизел", "Автоматична", 150, "https://s3.eu-west-2.amazonaws.com/assets.synetiq-auctions.co.uk/images/items/0026/0453805/cmih8vnjwohimemf7dj6fo5yqu6f5fsm9f52025a.jpg", false, new Guid("ae187b67-abd1-4c1a-8590-6a22c6de4b17"), "Citroen", "C5", 16000m, new Guid("8acdd8a8-ffaa-425d-934e-d13deaea1836"), 5, 70, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2016" },
                    { new Guid("3ccb56a9-4a35-4221-be4c-a8757d297461"), new Guid("bd91bf4e-67a8-40b4-a992-ae31c76df3a1"), 1200, 4, "Дизел", "Автоматична", 75, "https://www.auto-data.net/images/f11/Hyundai-Grand-i10-facelift-2017.jpg", false, new Guid("48141d40-a443-4edf-aa93-80a12db8690e"), "Hyundai", "i10", 10500m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 40, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2017" },
                    { new Guid("3cf850a3-2278-4a70-af61-157bc9e9f69a"), new Guid("4012cbab-8211-4c37-8566-f73f083e999f"), 1600, 4, "Бензин", "Автоматична", 132, "https://www.avtotachki.com/wp-content/uploads/2020/11/toyota-corolla-2016-1024x685.jpg", false, new Guid("3cb2b945-5fb2-4489-805e-b879154902a6"), "Toyota", "Corolla", 19000m, new Guid("8acdd8a8-ffaa-425d-934e-d13deaea1836"), 5, 55, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2016" },
                    { new Guid("5149fb0c-d53e-4ecc-bea2-9d005edbbdd4"), new Guid("2fc4c7e6-cad0-4190-95b5-78a7420a1631"), 1500, 4, "Дизел", "Автоматична", 116, "https://www.elcarrocolombiano.com/wp-contentuploads/2020/03/20200304-/RENAULT-DUSTER-2021-PRECIO-CARACTERISTICAS-EN-BRASIL-01.jpg", false, new Guid("95d16d5b-0edb-46ed-9abc-822545a05860"), "Dacia", "Duster", 23000m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 50, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2021" },
                    { new Guid("5b0ddfa3-1bef-4993-a879-f643a34d374b"), new Guid("bd91bf4e-67a8-40b4-a992-ae31c76df3a1"), 1200, 4, "Бензин", "Автоматична", 110, "https://ssl.caranddriving.com/cdwebsite/image169.ashx?url=https://ssl.caranddriving.com/ssl/f2/images/used/big/peugeot2082015to2019.jpg", false, new Guid("ae187b67-abd1-4c1a-8590-6a22c6de4b17"), "Peugeot", "208", 10000m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 50, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2015" },
                    { new Guid("60b708ce-d98a-4c51-a39a-05a50fddf989"), new Guid("2fc4c7e6-cad0-4190-95b5-78a7420a1631"), 5700, 4, "Бензин", "Автоматична", 395, "https://di-uploads-pod12.dealerinspire.com/universitydodgeram/uploads/2017/11/2018Ram1500_UniversityDodge.jpg", false, new Guid("84a3dfe2-4c08-4e18-9156-7452e556c1dd"), "RAM", "1500", 45000m, new Guid("661d2044-185a-4911-8864-1285c0638e09"), 6, 90, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2018" },
                    { new Guid("6c57e66b-4ad8-445c-ba76-1408b86ad7fb"), new Guid("bd91bf4e-67a8-40b4-a992-ae31c76df3a1"), 1200, 4, "Дизел", "Автоматична", 75, "https://www.avtotachki.com/wp-content/uploads/2020/12/hyundai-i10-2017-1024x640.jpg", false, new Guid("84a3dfe2-4c08-4e18-9156-7452e556c1dd"), "Hyundai", "i10", 10000m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 40, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2017" },
                    { new Guid("98f82568-0fe5-4e75-87e1-c5688fe42860"), new Guid("bd91bf4e-67a8-40b4-a992-ae31c76df3a1"), 1600, 4, "Дизел", "Автоматична", 140, "https://m4.netinfo.bg/media/images/38599/38599839/655-402-renault-cliov-/test-drajv.jpg", false, new Guid("84a3dfe2-4c08-4e18-9156-7452e556c1dd"), "Renault", "Clio", 18000m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 45, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2020" },
                    { new Guid("99ec8db1-b331-452c-a22e-1cb72d05379f"), new Guid("247c145d-9b6d-4315-a68a-f8191b687429"), 3000, 2, "Дизел", "Автоматична", 180, "https://d2e5b8shawuel2.cloudfront.net/vehicle/285996/hlv/original.jpg", false, new Guid("84a3dfe2-4c08-4e18-9156-7452e556c1dd"), "Iveco", "35c18", 42000m, new Guid("661d2044-185a-4911-8864-1285c0638e09"), 3, 120, new Guid("8f40d349-c104-430e-81d4-ab1ba6390187"), "2018" },
                    { new Guid("a80bdd96-7a9e-49c1-be7b-bd7a371051ed"), new Guid("247c145d-9b6d-4315-a68a-f8191b687429"), 2300, 3, "Дизел", "Ръчна", 143, "https://ppdobrich.com/uploads/thumbnail/preoborudvan-mikrobus-reno-master-c880x465.jpg", false, new Guid("95d16d5b-0edb-46ed-9abc-822545a05860"), "Renault", "Master", 32000m, new Guid("661d2044-185a-4911-8864-1285c0638e09"), 17, 130, new Guid("8f40d349-c104-430e-81d4-ab1ba6390187"), "2018" },
                    { new Guid("a89b2858-ea73-4338-8e02-18d01ae2b008"), new Guid("2fc4c7e6-cad0-4190-95b5-78a7420a1631"), 3000, 4, "Дизел", "Автоматична", 286, "https://cdn.dealerspike.com/imglib/v1/800x600/imglib/Assets/Inventory/A6/07/A6070369-F91B-47F8-9FA9-93AEF34C7EB4.jpg", false, new Guid("ae187b67-abd1-4c1a-8590-6a22c6de4b17"), "Audi", "Q7", 55000m, new Guid("b5877ed2-bb7a-4a22-be82-6db9308cd2b7"), 5, 75, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2018" },
                    { new Guid("adac99fc-a75f-4af4-9f1e-3570d67e6017"), new Guid("2fc4c7e6-cad0-4190-95b5-78a7420a1631"), 3000, 4, "Дизел", "Автоматична", 286, "https://pictures.dealer.com/r/rockvilleaudiaoa/1813/530e70010e6e34ac80d27f60876ab89ex.jpg", false, new Guid("48141d40-a443-4edf-aa93-80a12db8690e"), "Audi", "Q8", 95000m, new Guid("b5877ed2-bb7a-4a22-be82-6db9308cd2b7"), 5, 75, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2020" },
                    { new Guid("c42c760d-0e3e-4194-a88e-7318a084faab"), new Guid("2fc4c7e6-cad0-4190-95b5-78a7420a1631"), 1500, 4, "Дизел", "Автоматична", 116, "https://upload.wikimedia.org/wikipedia/commons/c/c2/2018_Dacia_Duster_Comfort_1.6.jpg", false, new Guid("95d16d5b-0edb-46ed-9abc-822545a05860"), "Dacia", "Duster", 25000m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 50, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2021" },
                    { new Guid("d3c87fc7-8f2e-4385-88cf-750802a00157"), new Guid("5e2e101c-27c9-4b94-b2e8-8f2154a4389b"), 12800, 2, "Дизел", "Автоматична", 450, "https://st.mascus.com/imagetilewm/product/e5a8342d/mercedes-benz-actros-1846-ls,5897e6b7-1.jpg", false, new Guid("ae187b67-abd1-4c1a-8590-6a22c6de4b17"), "Mercedes-Benz", "Actros", 35000m, new Guid("661d2044-185a-4911-8864-1285c0638e09"), 2, 900, new Guid("f7fa7488-e482-493d-a27c-1f1a7d38f79b"), "2017" },
                    { new Guid("f2d53339-77a9-4d2a-a1bd-bd7ab0e07e26"), new Guid("247c145d-9b6d-4315-a68a-f8191b687429"), 2200, 3, "Дизел", "Ръчна", 163, "https://d2e5b8shawuel2.cloudfront.net/vehicle/284390/hlv/original.jpg", false, new Guid("48141d40-a443-4edf-aa93-80a12db8690e"), "Mercedes-Benz", "Sprinter 316", 32000m, new Guid("661d2044-185a-4911-8864-1285c0638e09"), 8, 100, new Guid("8f40d349-c104-430e-81d4-ab1ba6390187"), "2015" }
                });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
