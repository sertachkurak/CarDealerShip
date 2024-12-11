using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarDealership.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedVehiclesPart2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "CategoryId", "Cubage", "Doors", "FuelType", "GearBox", "HorsePower", "ImageUrl", "IsDeleted", "LocationId", "Make", "Model", "Price", "PurposeId", "Seats", "TankCapacity", "TypeId", "Year" },
                values: new object[,]
                {
                    { new Guid("00b87416-7414-4b06-a44f-62210845f836"), new Guid("bd91bf4e-67a8-40b4-a992-ae31c76df3a1"), 1600, 4, "Дизел", "Автоматична", 110, "https://media.stockmanager.ie/media/0380e15958fbd2bb2c34655d332a20d1.jpg", false, new Guid("ae187b67-abd1-4c1a-8590-6a22c6de4b17"), "Volkswagen", "Golf", 12500m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 50, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2013" },
                    { new Guid("0abb1b1d-5ec2-44c9-b599-e8a7647fd81a"), new Guid("2fc4c7e6-cad0-4190-95b5-78a7420a1631"), 1600, 4, "Дизел", "Автоматична", 130, "https://images.clickdealer.co.uk/vehicles/5611/5611012/large1/131132474.jpg", false, new Guid("95d16d5b-0edb-46ed-9abc-822545a05860"), "Renault", "Kadjar", 19500m, new Guid("8acdd8a8-ffaa-425d-934e-d13deaea1836"), 5, 65, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2017" },
                    { new Guid("2004fde6-f433-493b-88ca-dde6e0d65706"), new Guid("939d5a93-8d55-4ec3-b3ac-39a36cd1ff29"), 2000, 4, "Дизел", "Автоматична", 240, "https://lenkrad.bg/wp-content/uploads/2023/07/IMG_6052.jpg", false, new Guid("ae187b67-abd1-4c1a-8590-6a22c6de4b17"), "Volkswagen", "Passat", 35500m, new Guid("8acdd8a8-ffaa-425d-934e-d13deaea1836"), 5, 65, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2020" },
                    { new Guid("2370e89c-7765-45ae-8efb-e5a70013b66b"), new Guid("37545039-ea1a-4970-8a41-abe0005291fd"), 2000, 2, "Дизел", "Автоматична", 140, "https://www.motortrend.com/uploads/sites/5/2013/11/2013-Volkswagen-Scirocco-R-front-three-quarters1.jpg", false, new Guid("3cb2b945-5fb2-4489-805e-b879154902a6"), "Volkswagen", "Scirocco", 9500m, new Guid("8acdd8a8-ffaa-425d-934e-d13deaea1836"), 4, 55, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2013" },
                    { new Guid("2fc5d4c8-702f-4fa5-a9e7-4d85a90228bd"), new Guid("4012cbab-8211-4c37-8566-f73f083e999f"), 2000, 4, "Дизел", "Автоматична", 185, "https://i.iinfo.cz/images/379/C5-A0koda-Octavia-facelift-2017-v-Portugalsku-0001-orig.jpg", false, new Guid("84a3dfe2-4c08-4e18-9156-7452e556c1dd"), "Skoda", "Octavia", 22500m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 60, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2017" },
                    { new Guid("37fc7112-66de-4be0-ab16-5d7c77d04606"), new Guid("d5b9e746-1458-4c71-98a2-dd2962c8f694"), 1600, 2, "Дизел", "Ръчна", 92, "https://wallpapers.com/images/hd/caption-stylish-citroen-berlingoonthe-//open-road-r6rrgptqhdh95zwh.jpg", false, new Guid("95d16d5b-0edb-46ed-9abc-822545a05860"), "Citroen", "Berlingo", 9000m, new Guid("8acdd8a8-ffaa-425d-934e-d13deaea1836"), 2, 60, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2014" },
                    { new Guid("38653d82-bd5b-4a3e-b973-510fa121a9ae"), new Guid("2fc4c7e6-cad0-4190-95b5-78a7420a1631"), 1000, 4, "Бензин", "Автоматична", 90, "https://img-pa.auto1.com/img53/7a/537a451e1e8592af996df6d02497ae30/pa/FZ44914_961889bcd6782481a45aec95c890dda7.jpeg", false, new Guid("84a3dfe2-4c08-4e18-9156-7452e556c1dd"), "Dacia", "Sandero", 16000m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 60, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2018" },
                    { new Guid("3fbce59b-a6b9-42c4-bd47-1f11694c193d"), new Guid("4012cbab-8211-4c37-8566-f73f083e999f"), 2000, 4, "Бензин", "Автоматична", 210, "https://images.clickdealer.co.uk/vehicles/3303/3303862/large2/69922594.jpg", false, new Guid("3cb2b945-5fb2-4489-805e-b879154902a6"), "Audi", "A4", 1100m, new Guid("8acdd8a8-ffaa-425d-934e-d13deaea1836"), 5, 70, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2010" },
                    { new Guid("50150df2-d531-4f8c-a6c7-b1bf1b8dc76b"), new Guid("2fc4c7e6-cad0-4190-95b5-78a7420a1631"), 1500, 4, "Дизел", "Автоматична", 110, "https://autobild.bg/wp-content/uploads/2021/09/IMG_5826.jpg", false, new Guid("48141d40-a443-4edf-aa93-80a12db8690e"), "Opel", "Mokka", 23000m, new Guid("8acdd8a8-ffaa-425d-934e-d13deaea1836"), 5, 45, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2020" },
                    { new Guid("6abf743a-068b-404d-94ee-65c2d37c9884"), new Guid("2fc4c7e6-cad0-4190-95b5-78a7420a1631"), 2200, 4, "Дизел", "Ръчна", 150, "https://media.ed.edmunds-media.com/honda/cr-v/2015/oem/2015_honda_cr-v_4dr-suv_touring_fq_oem_1_1600.jpg", false, new Guid("95d16d5b-0edb-46ed-9abc-822545a05860"), "Honda", "Cr-v", 24500m, new Guid("8acdd8a8-ffaa-425d-934e-d13deaea1836"), 5, 70, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2015" },
                    { new Guid("6b18a4a3-893d-4104-9a82-fcdac5398865"), new Guid("a2a6b9be-e626-4d0d-9152-8797da33402f"), 2000, 4, "Дизел", "Автоматична", 140, "https://cdn3.riastatic.com/photos/ir/new/auto/photo/volkswagen_sharan__344776878-620x415x70.jpg", false, new Guid("95d16d5b-0edb-46ed-9abc-822545a05860"), "Volkswagen", "Sharan", 15000m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 70, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2012" },
                    { new Guid("704fc770-11e6-498a-875f-5cb8afdbc95f"), new Guid("d5b9e746-1458-4c71-98a2-dd2962c8f694"), 1700, 4, "Дизел", "Ръчна", 75, "https://img.autoabc.lv/opel-meriva/opel-meriva_2003_Minivens_1512150409_4.jpg", false, new Guid("3cb2b945-5fb2-4489-805e-b879154902a6"), "Opel", "Meriva", 2500m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 60, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2004" },
                    { new Guid("9f7db9e9-bb94-48d9-a670-9fa20affc1e5"), new Guid("bd91bf4e-67a8-40b4-a992-ae31c76df3a1"), 1200, 4, "Бензин", "Автоматична", 110, "https://cloud.leparking.fr/2021/04/27/00/23/peugeot-208-peugeot-208-2015-67000km-garantie-inconnu_8085850837.jpg", false, new Guid("3cb2b945-5fb2-4489-805e-b879154902a6"), "Peugeot", "208", 9000m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 5, 50, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2015" },
                    { new Guid("a2031693-939a-4d73-b619-8a8fd5797e05"), new Guid("2fc4c7e6-cad0-4190-95b5-78a7420a1631"), 2200, 4, "Дизел", "Ръчка", 150, "https://abstoragev4.blob.core.windows.net/auctions/39678/cars/medium/39678-1_ex.jpg", false, new Guid("48141d40-a443-4edf-aa93-80a12db8690e"), "Ford", "Ranger", 27000m, new Guid("661d2044-185a-4911-8864-1285c0638e09"), 5, 80, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2012" },
                    { new Guid("b4d74e18-6399-4e1a-b418-fb18052cb5e2"), new Guid("bd91bf4e-67a8-40b4-a992-ae31c76df3a1"), 2000, 2, "Дизел", "Автоматична", 136, "https://www.auto-data.net/images/f21/Peugeot-307-facelift-2005.jpg", false, new Guid("48141d40-a443-4edf-aa93-80a12db8690e"), "Peugeot", "307", 5500m, new Guid("f140b03d-b93a-47e6-a58a-346fad8599ad"), 4, 50, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2009" },
                    { new Guid("c54d611b-c559-4468-9782-3b6a34d139e6"), new Guid("4012cbab-8211-4c37-8566-f73f083e999f"), 3000, 4, "Дизел", "Автоматична", 244, "https://www.motorbeam.com/wp-content/uploads/Jaguar-XF-Diesel-Review-1200x900.jpg", false, new Guid("48141d40-a443-4edf-aa93-80a12db8690e"), "Jaguar", "XF", 23500m, new Guid("8acdd8a8-ffaa-425d-934e-d13deaea1836"), 5, 80, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2018" },
                    { new Guid("c57cbde2-3556-49b0-9cf6-34e0525593ad"), new Guid("939d5a93-8d55-4ec3-b3ac-39a36cd1ff29"), 1400, 4, "Дизел", "Ръчни", 90, "https://aaaautoeuimg.vshcdn.net/thumb/900482724_640x480x95.jpg?58802", false, new Guid("84a3dfe2-4c08-4e18-9156-7452e556c1dd"), "Toyota", "Auris", 13000m, new Guid("adf8cee2-4a4f-430a-99a4-b80fcda4d62d"), 5, 50, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2013" },
                    { new Guid("cc71fae8-9d50-4541-8d4b-285b3fc6ca98"), new Guid("d5b9e746-1458-4c71-98a2-dd2962c8f694"), 1600, 2, "Дизел", "Ръчна", 92, "https://media.drive.com.au/obj/tx_q:50,rs:auto:1920:1080:1/caradvice/private/4d113513f8e3801b4248fda3c2517c04", false, new Guid("ae187b67-abd1-4c1a-8590-6a22c6de4b17"), "Citroen", "Berlingo", 9000m, new Guid("8acdd8a8-ffaa-425d-934e-d13deaea1836"), 2, 60, new Guid("912d4786-5ce9-4dc7-8da8-47ce8fb72bef"), "2014" },
                    { new Guid("e6a35b61-f23a-497c-ae74-e7ebff1c9be0"), new Guid("5e2e101c-27c9-4b94-b2e8-8f2154a4389b"), 13000, 2, "Дизел", "Автоматична", 480, "https://www.truck1.bg/img/Vlekach_DAF_XF_480_FT_EURO_6_ADR-xxl-8235/8235_5044513319890.jpg", false, new Guid("84a3dfe2-4c08-4e18-9156-7452e556c1dd"), "Daf", "XF 408", 88999m, new Guid("661d2044-185a-4911-8864-1285c0638e09"), 2, 1200, new Guid("f7fa7488-e482-493d-a27c-1f1a7d38f79b"), "2020" },
                    { new Guid("e991d671-419a-44df-a608-587fa101b229"), new Guid("247c145d-9b6d-4315-a68a-f8191b687429"), 2000, 4, "Дизел", "Ръчна", 130, "https://images.clickdealer.co.uk/vehicles/4175/4175102/large2/92193323.jpg", false, new Guid("ae187b67-abd1-4c1a-8590-6a22c6de4b17"), "Ford", "Transit", 27000m, new Guid("661d2044-185a-4911-8864-1285c0638e09"), 3, 90, new Guid("8f40d349-c104-430e-81d4-ab1ba6390187"), "2019" }
                });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {


        }
    }
}
