using CarDealership.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealership.Data.Configuration
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(GenerateVehicle());
        }

        private List<Vehicle> GenerateVehicle()
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                //new Vehicle()
                //{
                //    Id = Guid.Parse("F140489D-C0B6-42A8-A1D5-F5FA76E1E508"),
                //    Make = "Mercedes-Benz",
                //    Model = "S 500",
                //    Price = 80000,
                //    FuelType = "Бензин",
                //    GearBox = "Автоматична",
                //    Year = "2016",
                //    Doors = 4,
                //    Seats = 5,
                //    TankCapacity = 90,
                //    HorsePower = 455,
                //    Cubage = 5000,
                //    ImageUrl = "https://editorial.pxcrush.net/carsales/general/editorial/ge5710401472975685544.jpg?width=1024&height=682",
                //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                //    CategoryId = Guid.Parse("4012CBAB-8211-4C37-8566-F73F083E999F"),
                //    LocationId = Guid.Parse("AE187B67-ABD1-4C1A-8590-6A22C6DE4B17"),
                //    PurposeId = Guid.Parse("B5877ED2-BB7A-4A22-BE82-6DB9308CD2B7")

                //},
                //new Vehicle()
                //{
                //    Id = Guid.Parse("09F490CA-6410-4A2C-8C0B-8126DEB481D9"),
                //    Make = "BMW",
                //    Model = "760",
                //    Price = 180000,
                //    FuelType = "Бензин",
                //    GearBox = "Автоматична",
                //    Year = "2019",
                //    Doors = 4,
                //    Seats = 5,
                //    TankCapacity = 100,
                //    HorsePower = 609,
                //    Cubage = 6000,
                //    ImageUrl = "https://a4d540d8508d4f8a94eefc64d221e3d5.objectstore.eu/lot-20087413/1000x0/94a340b554216b7d5753cdc44dc7217c.jpg",
                //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                //    CategoryId = Guid.Parse("4012CBAB-8211-4C37-8566-F73F083E999F"),
                //    LocationId = Guid.Parse("84A3DFE2-4C08-4E18-9156-7452E556C1DD"),
                //    PurposeId = Guid.Parse("B5877ED2-BB7A-4A22-BE82-6DB9308CD2B7")

                //},
                //new Vehicle()
                //{
                //    Id = Guid.Parse("238DE9B6-279E-4488-AE1E-89B0098EDCCF"),
                //    Make = "Audi",
                //    Model = "A8",
                //    Price = 90000,
                //    FuelType = "Бензин",
                //    GearBox = "Автоматична",
                //    Year = "2018",
                //    Doors = 4,
                //    Seats = 5,
                //    TankCapacity = 90,
                //    HorsePower = 340,
                //    Cubage = 3000,
                //    ImageUrl = "https://a4d540d8508d4f8a94eefc64d221e3d5.objectstore.eu/lot-19801563/1000x0/d00867bc670fa9c6fcae88c376ab6628.jpg",
                //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                //    CategoryId = Guid.Parse("4012CBAB-8211-4C37-8566-F73F083E999F"),
                //    LocationId = Guid.Parse("48141D40-A443-4EDF-AA93-80A12DB8690E"),
                //    PurposeId = Guid.Parse("B5877ED2-BB7A-4A22-BE82-6DB9308CD2B7")

                //},
                //new Vehicle()
                //{
                //    Id = Guid.Parse("D851B2B2-9786-42E3-ADAB-90C8CB87A138"),
                //    Make = "Mercedes-Benz",
                //    Model = "S 350",
                //    Price = 100000,
                //    FuelType = "Бензин",
                //    GearBox = "Автоматична",
                //    Year = "2020",
                //    Doors = 2,
                //    Seats = 4,
                //    TankCapacity = 70,
                //    HorsePower = 299,
                //    Cubage = 2000,
                //    ImageUrl = "https://static.auctionauto.com.ua/images/image.autowini.com/AUTOWINI4/UploadImage/Thumb/202206/20/CI202206200001520806/1655653021563_1024.jpg",
                //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                //    CategoryId = Guid.Parse("37545039-EA1A-4970-8A41-ABE0005291FD"),
                //    LocationId = Guid.Parse("95D16D5B-0EDB-46ED-9ABC-822545A05860"),
                //    PurposeId = Guid.Parse("B5877ED2-BB7A-4A22-BE82-6DB9308CD2B7")

                //},
                //new Vehicle()
                //{
                //    Id = Guid.Parse("427FD628-B2B6-405C-A6FB-BCD500A3FFD9"),
                //    Make = "Porsche",
                //    Model = "911 Turbo S",
                //    Price = 270000,
                //    FuelType = "Бензин",
                //    GearBox = "Автоматична",
                //    Year = "2014",
                //    Doors = 2,
                //    Seats = 4,
                //    TankCapacity = 80,
                //    HorsePower = 560,
                //    Cubage = 3800,
                //    ImageUrl = "https://www.perfectautocollection.com/imagetag/3466/2/l/Used-2014-Porsche-911-Turbo-S-1722623538.jpg",
                //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                //    CategoryId = Guid.Parse("37545039-EA1A-4970-8A41-ABE0005291FD"),
                //    LocationId = Guid.Parse("3CB2B945-5FB2-4489-805E-B879154902A6"),
                //    PurposeId = Guid.Parse("B5877ED2-BB7A-4A22-BE82-6DB9308CD2B7")

                //},
                // new Vehicle()
                // {
                //     Id = Guid.Parse("ABD1D814-D632-4CE7-A367-B0C527FB1941"),
                //   Make = "Land Rover",
                //   Model = "Defender",
                //   Price = 160000,
                //   FuelType = "Дизел",
                //   GearBox = "Автоматична",
                //   Year = "2023",
                //   Doors = 4,
                //   Seats = 5,
                //   TankCapacity = 95,
                //   HorsePower = 250,
                //   Cubage = 3000,
                //   ImageUrl = "https://www.southeastautoshowroom.com/imagetag/1492/mainlUsed-2023Land-/Rover-Defender-110-X-1682620154.jpg",
                //   TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                //   CategoryId = Guid.Parse("37545039-EA1A-4970-8A41-ABE0005291FD"),
                //   LocationId = Guid.Parse("AE187B67-ABD1-4C1A-8590-6A22C6DE4B17"),
                //   PurposeId = Guid.Parse("661D2044-185A-4911-8864-1285C0638E09")

                // },
                // new Vehicle()
                // {
                //     Id = Guid.Parse("9A4B8516-7536-4F68-95EB-259354CB47F2"),
                //   Make = "Audi",
                //   Model = "RS6",
                //   Price = 110000,
                //   FuelType = "Бензин",
                //   GearBox = "Автоматична",
                //   Year = "2016",
                //   Doors = 4,
                //   Seats = 5,
                //   TankCapacity = 100,
                //   HorsePower = 605,
                //   Cubage = 4000,
                //   ImageUrl = "https://gtspirit.com/wp-content/uploads/2015/05/Audi-RS6-Avant-2.jpg",
                //   TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                //   CategoryId = Guid.Parse("939D5A93-8D55-4EC3-B3AC-39A36CD1FF29"),
                //   LocationId = Guid.Parse("84A3DFE2-4C08-4E18-9156-7452E556C1DD"),
                //   PurposeId = Guid.Parse("B5877ED2-BB7A-4A22-BE82-6DB9308CD2B7")

                // },
                // new Vehicle()
                // {
                //     Id = Guid.Parse("19F498B3-EC25-4A68-A65F-FC6262E11C7B"),
                //   Make = "Bentley",
                //   Model = "Continental GT",
                //   Price = 470000,
                //   FuelType = "Бензин",
                //   GearBox = "Автоматична",
                //   Year = "2022",
                //   Doors = 2,
                //   Seats = 4,
                //   TankCapacity = 100,
                //   HorsePower = 549,
                //   Cubage = 4000,
                //   ImageUrl = "https://www.carpixel.netw/3606b3152f8facfae42a639f23b09c95bentleycontinental-gt-s-wallpaperhd-109039.jpg",
                //   TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                //   CategoryId = Guid.Parse("37545039-EA1A-4970-8A41-ABE0005291FD"),
                //   LocationId = Guid.Parse("48141D40-A443-4EDF-AA93-80A12DB8690E"),
                //   PurposeId = Guid.Parse("B5877ED2-BB7A-4A22-BE82-6DB9308CD2B7")

                // },
                // new Vehicle()
                // {
                //     Id = Guid.Parse("0AF30CC4-CC9F-4EE3-AA86-711F7C30345E"),
                //   Make = "Aston martin",
                //   Model = "DBS",
                //   Price = 500000,
                //   FuelType = "Бензин",
                //   GearBox = "Автоматична",
                //   Year = "2022",
                //   Doors = 2,
                //   Seats = 4,
                //   TankCapacity = 120,
                //   HorsePower = 639,
                //   Cubage = 5200,
                //   ImageUrl = "https://www.astonmartinwashingtondc.comimagetag/3371/3lNew-2022Aston-Martin-DBS-Superleggera-1664901853.jpg",
                //   TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                //   CategoryId = Guid.Parse("37545039-EA1A-4970-8A41-ABE0005291FD"),
                //   LocationId = Guid.Parse("95D16D5B-0EDB-46ED-9ABC-822545A05860"),
                //   PurposeId = Guid.Parse("B5877ED2-BB7A-4A22-BE82-6DB9308CD2B7")

                // },
                // new Vehicle()
                // {
                //     Id = Guid.Parse("71B3AD65-17CF-48AC-9E67-808B897978A7"),
                //     Make = "Fiat",
                //     Model = "Talento",
                //     Price = 18999,
                //     FuelType = "Дизел",
                //     GearBox = "Ръчна",
                //     Year = "2017",
                //     Doors = 4,
                //     Seats = 3,
                //     TankCapacity = 70,
                //     HorsePower = 120,
                //     Cubage = 1600,
                //     ImageUrl = "https://static-eu.cargurus.com/images/forsale/2024/09/11/21/37/2018_fiat_talento-pic-8046155731279073145-1024x768.jpeg",
                //     TypeId = Guid.Parse("8F40D349-C104-430E-81D4-AB1BA6390187"),
                //     CategoryId = Guid.Parse("247C145D-9B6D-4315-A68A-F8191B687429"),
                //     LocationId = Guid.Parse("3CB2B945-5FB2-4489-805E-B879154902A6"),
                //     PurposeId = Guid.Parse("661D2044-185A-4911-8864-1285C0638E09")

                //},
               // new Vehicle()
               // {
               //     Id = Guid.Parse("E991D671-419A-44DF-A608-587FA101B229"),
               //     Make = "Ford",
               //     Model = "Transit",
               //     Price = 27000,
               //     FuelType = "Дизел",
               //     GearBox = "Ръчна",
               //     Year = "2019",
               //     Doors = 4,
               //     Seats = 3,
               //     TankCapacity = 90,
               //     HorsePower = 130,
               //     Cubage = 2000,
               //     ImageUrl = "https://images.clickdealer.co.uk/vehicles/4175/4175102/large2/92193323.jpg",
               //     TypeId = Guid.Parse("8F40D349-C104-430E-81D4-AB1BA6390187"),
               //     CategoryId = Guid.Parse("247C145D-9B6D-4315-A68A-F8191B687429"),
               //     LocationId = Guid.Parse("AE187B67-ABD1-4C1A-8590-6A22C6DE4B17"),
               //     PurposeId = Guid.Parse("661D2044-185A-4911-8864-1285C0638E09")

               // },
               // new Vehicle()
               // {
               //     Id = Guid.Parse("E6A35B61-F23A-497C-AE74-E7EBFF1C9BE0"),
               //     Make = "Daf",
               //     Model = "XF 408",
               //     Price = 88999,
               //     FuelType = "Дизел",
               //     GearBox = "Автоматична",
               //     Year = "2020",
               //     Doors = 2,
               //     Seats = 2,
               //     TankCapacity = 1200,
               //     HorsePower = 480,
               //     Cubage = 13000,
               //     ImageUrl = "https://www.truck1.bg/img/Vlekach_DAF_XF_480_FT_EURO_6_ADR-xxl-8235/8235_5044513319890.jpg",
               //     TypeId = Guid.Parse("F7FA7488-E482-493D-A27C-1F1A7D38F79B"),
               //     CategoryId = Guid.Parse("5E2E101C-27C9-4B94-B2E8-8F2154A4389B"),
               //     LocationId = Guid.Parse("84A3DFE2-4C08-4E18-9156-7452E556C1DD"),
               //     PurposeId = Guid.Parse("661D2044-185A-4911-8864-1285C0638E09")

               // },
               // new Vehicle()
               // {
               //     Id = Guid.Parse("A2031693-939A-4D73-B619-8A8FD5797E05"),
               //     Make = "Ford",
               //     Model = "Ranger",
               //     Price = 27000,
               //     FuelType = "Дизел",
               //     GearBox = "Ръчка",
               //     Year = "2012",
               //     Doors = 4,
               //     Seats = 5,
               //     TankCapacity = 80,
               //     HorsePower = 150,
               //     Cubage = 2200,
               //     ImageUrl = "https://abstoragev4.blob.core.windows.net/auctions/39678/cars/medium/39678-1_ex.jpg",
               //     TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //     CategoryId = Guid.Parse("2FC4C7E6-CAD0-4190-95B5-78A7420A1631"),
               //     LocationId = Guid.Parse("48141D40-A443-4EDF-AA93-80A12DB8690E"),
               //     PurposeId = Guid.Parse("661D2044-185A-4911-8864-1285C0638E09")

               // },
               // new Vehicle()
               // {
               //     Id = Guid.Parse("37FC7112-66DE-4BE0-AB16-5D7C77D04606"),
               //     Make = "Citroen",
               //     Model = "Berlingo",
               //     Price = 9000,
               //     FuelType = "Дизел",
               //     GearBox = "Ръчна",
               //     Year = "2014",
               //     Doors = 2,
               //     Seats = 2,
               //     TankCapacity = 60,
               //     HorsePower = 92,
               //     Cubage = 1600,
               //     ImageUrl = "https://wallpapers.com/images/hd/caption-stylish-citroen-berlingoonthe-//open-road-r6rrgptqhdh95zwh.jpg",
               //     TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //     CategoryId = Guid.Parse("D5B9E746-1458-4C71-98A2-DD2962C8F694"),
               //     LocationId = Guid.Parse("95D16D5B-0EDB-46ED-9ABC-822545A05860"),
               //     PurposeId = Guid.Parse("8ACDD8A8-FFAA-425D-934E-D13DEAEA1836")

               // },
               //new Vehicle()
               //{
               //    Id = Guid.Parse("3FBCE59B-A6B9-42C4-BD47-1F11694C193D"),
               //    Make = "Audi",
               //    Model = "A4",
               //    Price = 1100,
               //    FuelType = "Бензин",
               //    GearBox = "Автоматична",
               //    Year = "2010",
               //    Doors = 4,
               //    Seats = 5,
               //    TankCapacity = 70,
               //    HorsePower = 210,
               //    Cubage = 2000,
               //    ImageUrl = "https://images.clickdealer.co.uk/vehicles/3303/3303862/large2/69922594.jpg",
               //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //    CategoryId = Guid.Parse("4012CBAB-8211-4C37-8566-F73F083E999F"),
               //    LocationId = Guid.Parse("3CB2B945-5FB2-4489-805E-B879154902A6"),
               //    PurposeId = Guid.Parse("8ACDD8A8-FFAA-425D-934E-D13DEAEA1836")

               //},
               //new Vehicle()
               //{
               //    Id = Guid.Parse("CC71FAE8-9D50-4541-8D4B-285B3FC6CA98"),
               //    Make = "Citroen",
               //    Model = "Berlingo",
               //    Price = 9000,
               //    FuelType = "Дизел",
               //    GearBox = "Ръчна",
               //    Year = "2014",
               //    Doors = 2,
               //    Seats = 2,
               //    TankCapacity = 60,
               //    HorsePower = 92,
               //    Cubage = 1600,
               //    ImageUrl = "https://media.drive.com.au/obj/tx_q:50,rs:auto:1920:1080:1/caradvice/private/4d113513f8e3801b4248fda3c2517c04",
               //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //    CategoryId = Guid.Parse("D5B9E746-1458-4C71-98A2-DD2962C8F694"),
               //    LocationId = Guid.Parse("AE187B67-ABD1-4C1A-8590-6A22C6DE4B17"),
               //    PurposeId = Guid.Parse("8ACDD8A8-FFAA-425D-934E-D13DEAEA1836")

               //},
               //new Vehicle()
               //{
               //    Id = Guid.Parse("38653D82-BD5B-4A3E-B973-510FA121A9AE"),
               //    Make = "Dacia",
               //    Model = "Sandero",
               //    Price = 16000,
               //    FuelType = "Бензин",
               //    GearBox = "Автоматична",
               //    Year = "2018",
               //    Doors = 4,
               //    Seats = 5,
               //    TankCapacity = 60,
               //    HorsePower = 90,
               //    Cubage = 1000,
               //    ImageUrl = "https://img-pa.auto1.com/img53/7a/537a451e1e8592af996df6d02497ae30/pa/FZ44914_961889bcd6782481a45aec95c890dda7.jpeg",
               //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //    CategoryId = Guid.Parse("2FC4C7E6-CAD0-4190-95B5-78A7420A1631"),
               //    LocationId = Guid.Parse("84A3DFE2-4C08-4E18-9156-7452E556C1DD"),
               //    PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

               //},
               //new Vehicle()
               //{
               //    Id = Guid.Parse("C54D611B-C559-4468-9782-3B6A34D139E6"),
               //    Make = "Jaguar",
               //    Model = "XF",
               //    Price = 23500,
               //    FuelType = "Дизел",
               //    GearBox = "Автоматична",
               //    Year = "2018",
               //    Doors = 4,
               //    Seats = 5,
               //    TankCapacity = 80,
               //    HorsePower = 244,
               //    Cubage = 3000,
               //    ImageUrl = "https://www.motorbeam.com/wp-content/uploads/Jaguar-XF-Diesel-Review-1200x900.jpg",
               //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //    CategoryId = Guid.Parse("4012CBAB-8211-4C37-8566-F73F083E999F"),
               //    LocationId = Guid.Parse("48141D40-A443-4EDF-AA93-80A12DB8690E"),
               //    PurposeId = Guid.Parse("8ACDD8A8-FFAA-425D-934E-D13DEAEA1836")

               //},
               //new Vehicle()
               //{
               //    Id = Guid.Parse("6ABF743A-068B-404D-94EE-65C2D37C9884"),
               //    Make = "Honda",
               //    Model = "Cr-v",
               //    Price = 24500,
               //    FuelType = "Дизел",
               //    GearBox = "Ръчна",
               //    Year = "2015",
               //    Doors = 4,
               //    Seats = 5,
               //    TankCapacity = 70,
               //    HorsePower = 150,
               //    Cubage = 2200,
               //    ImageUrl = "https://media.ed.edmunds-media.com/honda/cr-v/2015/oem/2015_honda_cr-v_4dr-suv_touring_fq_oem_1_1600.jpg",
               //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //    CategoryId = Guid.Parse("2FC4C7E6-CAD0-4190-95B5-78A7420A1631"),
               //    LocationId = Guid.Parse("95D16D5B-0EDB-46ED-9ABC-822545A05860"),
               //    PurposeId = Guid.Parse("8ACDD8A8-FFAA-425D-934E-D13DEAEA1836")

               //},
               //new Vehicle()
               //{
               //    Id = Guid.Parse("704FC770-11E6-498A-875F-5CB8AFDBC95F"),
               //    Make = "Opel",
               //    Model = "Meriva",
               //    Price = 2500,
               //    FuelType = "Дизел",
               //    GearBox = "Ръчна",
               //    Year = "2004",
               //    Doors = 4,
               //    Seats = 5,
               //    TankCapacity = 60,
               //    HorsePower = 75,
               //    Cubage = 1700,
               //    ImageUrl = "https://img.autoabc.lv/opel-meriva/opel-meriva_2003_Minivens_1512150409_4.jpg",
               //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //    CategoryId = Guid.Parse("D5B9E746-1458-4C71-98A2-DD2962C8F694"),
               //    LocationId = Guid.Parse("3CB2B945-5FB2-4489-805E-B879154902A6"),
               //    PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

               //},
               //new Vehicle()
               //{
               //    Id = Guid.Parse("2004FDE6-F433-493B-88CA-DDE6E0D65706"),
               //    Make = "Volkswagen",
               //    Model = "Passat",
               //    Price = 35500,
               //    FuelType = "Дизел",
               //    GearBox = "Автоматична",
               //    Year = "2020",
               //    Doors = 4,
               //    Seats = 5,
               //    TankCapacity = 65,
               //    HorsePower = 240,
               //    Cubage = 2000,
               //    ImageUrl = "https://lenkrad.bg/wp-content/uploads/2023/07/IMG_6052.jpg",
               //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //    CategoryId = Guid.Parse("939D5A93-8D55-4EC3-B3AC-39A36CD1FF29"),
               //    LocationId = Guid.Parse("AE187B67-ABD1-4C1A-8590-6A22C6DE4B17"),
               //    PurposeId = Guid.Parse("8ACDD8A8-FFAA-425D-934E-D13DEAEA1836")

               //},

               // new Vehicle()
               // {
               //     Id = Guid.Parse("2FC5D4C8-702F-4FA5-A9E7-4D85A90228BD"),
               //     Make = "Skoda",
               //     Model = "Octavia",
               //     Price = 22500,
               //     FuelType = "Дизел",
               //     GearBox = "Автоматична",
               //     Year = "2017",
               //     Doors = 4,
               //     Seats = 5,
               //     TankCapacity = 60,
               //     HorsePower = 185,
               //     Cubage = 2000,
               //     ImageUrl = "https://i.iinfo.cz/images/379/C5-A0koda-Octavia-facelift-2017-v-Portugalsku-0001-orig.jpg",
               //     TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //     CategoryId = Guid.Parse("4012CBAB-8211-4C37-8566-F73F083E999F"),
               //     LocationId = Guid.Parse("84A3DFE2-4C08-4E18-9156-7452E556C1DD"),
               //     PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

               // },

               // new Vehicle()
               // {
               //     Id = Guid.Parse("B4D74E18-6399-4E1A-B418-FB18052CB5E2"),
               //     Make = "Peugeot",
               //     Model = "307",
               //     Price = 5500,
               //     FuelType = "Дизел",
               //     GearBox = "Автоматична",
               //     Year = "2009",
               //     Doors = 2,
               //     Seats = 4,
               //     TankCapacity = 50,
               //     HorsePower = 136,
               //     Cubage = 2000,
               //     ImageUrl = "https://www.auto-data.net/images/f21/Peugeot-307-facelift-2005.jpg",
               //     TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //     CategoryId = Guid.Parse("BD91BF4E-67A8-40B4-A992-AE31C76DF3A1"),
               //     LocationId = Guid.Parse("48141D40-A443-4EDF-AA93-80A12DB8690E"),
               //     PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

               // },

               // new Vehicle()
               // {
               //     Id = Guid.Parse("0ABB1B1D-5EC2-44C9-B599-E8A7647FD81A"),
               //     Make = "Renault",
               //     Model = "Kadjar",
               //     Price = 19500,
               //     FuelType = "Дизел",
               //     GearBox = "Автоматична",
               //     Year = "2017",
               //     Doors = 4,
               //     Seats = 5,
               //     TankCapacity = 65,
               //     HorsePower = 130,
               //     Cubage = 1600,
               //     ImageUrl = "https://images.clickdealer.co.uk/vehicles/5611/5611012/large1/131132474.jpg",
               //     TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //     CategoryId = Guid.Parse("2FC4C7E6-CAD0-4190-95B5-78A7420A1631"),
               //     LocationId = Guid.Parse("95D16D5B-0EDB-46ED-9ABC-822545A05860"),
               //     PurposeId = Guid.Parse("8ACDD8A8-FFAA-425D-934E-D13DEAEA1836")

               // },

               // new Vehicle()
               // {
               //     Id = Guid.Parse("2370E89C-7765-45AE-8EFB-E5A70013B66B"),
               //     Make = "Volkswagen",
               //     Model = "Scirocco",
               //     Price = 9500,
               //     FuelType = "Дизел",
               //     GearBox = "Автоматична",
               //     Year = "2013",
               //     Doors = 2,
               //     Seats = 4,
               //     TankCapacity = 55,
               //     HorsePower = 140,
               //     Cubage = 2000,
               //     ImageUrl = "https://www.motortrend.com/uploads/sites/5/2013/11/2013-Volkswagen-Scirocco-R-front-three-quarters1.jpg",
               //     TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //     CategoryId = Guid.Parse("37545039-EA1A-4970-8A41-ABE0005291FD"),
               //     LocationId = Guid.Parse("3CB2B945-5FB2-4489-805E-B879154902A6"),
               //     PurposeId = Guid.Parse("8ACDD8A8-FFAA-425D-934E-D13DEAEA1836")

               // },

               //new Vehicle()
               //{
               //    Id = Guid.Parse("00B87416-7414-4B06-A44F-62210845F836"),
               //    Make = "Volkswagen",
               //    Model = "Golf",
               //    Price = 12500,
               //    FuelType = "Дизел",
               //    GearBox = "Автоматична",
               //    Year = "2013",
               //    Doors = 4,
               //    Seats = 5,
               //    TankCapacity = 50,
               //    HorsePower = 110,
               //    Cubage = 1600,
               //    ImageUrl = "https://media.stockmanager.ie/media/0380e15958fbd2bb2c34655d332a20d1.jpg",
               //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //    CategoryId = Guid.Parse("BD91BF4E-67A8-40B4-A992-AE31C76DF3A1"),
               //    LocationId = Guid.Parse("AE187B67-ABD1-4C1A-8590-6A22C6DE4B17"),
               //    PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

               //},
               //new Vehicle()
               //{
               //    Id = Guid.Parse("C57CBDE2-3556-49B0-9CF6-34E0525593AD"),
               //    Make = "Toyota",
               //    Model = "Auris",
               //    Price = 13000,
               //    FuelType = "Дизел",
               //    GearBox = "Ръчни",
               //    Year = "2013",
               //    Doors = 4,
               //    Seats = 5,
               //    TankCapacity = 50,
               //    HorsePower = 90,
               //    Cubage = 1400,
               //    ImageUrl = "https://aaaautoeuimg.vshcdn.net/thumb/900482724_640x480x95.jpg?58802",
               //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //    CategoryId = Guid.Parse("939D5A93-8D55-4EC3-B3AC-39A36CD1FF29"),
               //    LocationId = Guid.Parse("84A3DFE2-4C08-4E18-9156-7452E556C1DD"),
               //    PurposeId = Guid.Parse("ADF8CEE2-4A4F-430A-99A4-B80FCDA4D62D")

               //},

               //new Vehicle()
               //{
               //    Id = Guid.Parse("50150DF2-D531-4F8C-A6C7-B1BF1B8DC76B"),
               //    Make = "Opel",
               //    Model = "Mokka",
               //    Price = 23000,
               //    FuelType = "Дизел",
               //    GearBox = "Автоматична",
               //    Year = "2020",
               //    Doors = 4,
               //    Seats = 5,
               //    TankCapacity = 45,
               //    HorsePower = 110,
               //    Cubage = 1500,
               //    ImageUrl = "https://autobild.bg/wp-content/uploads/2021/09/IMG_5826.jpg",
               //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //    CategoryId = Guid.Parse("2FC4C7E6-CAD0-4190-95B5-78A7420A1631"),
               //    LocationId = Guid.Parse("48141D40-A443-4EDF-AA93-80A12DB8690E"),
               //    PurposeId = Guid.Parse("8ACDD8A8-FFAA-425D-934E-D13DEAEA1836")

               //},

               //new Vehicle()
               //{
               //    Id = Guid.Parse("6B18A4A3-893D-4104-9A82-FCDAC5398865"),
               //    Make = "Volkswagen",
               //    Model = "Sharan",
               //    Price = 15000,
               //    FuelType = "Дизел",
               //    GearBox = "Автоматична",
               //    Year = "2012",
               //    Doors = 4,
               //    Seats = 5,
               //    TankCapacity = 70,
               //    HorsePower = 140,
               //    Cubage = 2000,
               //    ImageUrl = "https://cdn3.riastatic.com/photos/ir/new/auto/photo/volkswagen_sharan__344776878-620x415x70.jpg",
               //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //    CategoryId = Guid.Parse("A2A6B9BE-E626-4D0D-9152-8797DA33402F"),
               //    LocationId = Guid.Parse("95D16D5B-0EDB-46ED-9ABC-822545A05860"),
               //    PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

               //},

               //new Vehicle()
               //{
               //    Id = Guid.Parse("9F7DB9E9-BB94-48D9-A670-9FA20AFFC1E5"),
               //    Make = "Peugeot",
               //    Model = "208",
               //    Price = 9000,
               //    FuelType = "Бензин",
               //    GearBox = "Автоматична",
               //    Year = "2015",
               //    Doors = 4,
               //    Seats = 5,
               //    TankCapacity = 50,
               //    HorsePower = 110,
               //    Cubage = 1200,
               //    ImageUrl = "https://cloud.leparking.fr/2021/04/27/00/23/peugeot-208-peugeot-208-2015-67000km-garantie-inconnu_8085850837.jpg",
               //    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
               //    CategoryId = Guid.Parse("BD91BF4E-67A8-40B4-A992-AE31C76DF3A1"),
               //    LocationId = Guid.Parse("3CB2B945-5FB2-4489-805E-B879154902A6"),
               //    PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

               //},

               new Vehicle()
               {
                   Id = Guid.Parse("5B0DDFA3-1BEF-4993-A879-F643A34D374B"),
                   Make = "Peugeot",
                   Model = "208",
                   Price = 10000,
                   FuelType = "Бензин",
                   GearBox = "Автоматична",
                   Year = "2015",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 50,
                   HorsePower = 110,
                   Cubage = 1200,
                   ImageUrl = "https://ssl.caranddriving.com/cdwebsite/image169.ashx?url=https://ssl.caranddriving.com/ssl/f2/images/used/big/peugeot2082015to2019.jpg",
                   TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                   CategoryId = Guid.Parse("BD91BF4E-67A8-40B4-A992-AE31C76DF3A1"),
                   LocationId = Guid.Parse("AE187B67-ABD1-4C1A-8590-6A22C6DE4B17"),
                   PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

               },
               new Vehicle()
               {
                   Id = Guid.Parse("98F82568-0FE5-4E75-87E1-C5688FE42860"),
                   Make = "Renault",
                   Model = "Clio",
                   Price = 18000,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2020",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 45,
                   HorsePower = 140,
                   Cubage = 1600,
                   ImageUrl = "https://m4.netinfo.bg/media/images/38599/38599839/655-402-renault-cliov-/test-drajv.jpg",
                   TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                   CategoryId = Guid.Parse("BD91BF4E-67A8-40B4-A992-AE31C76DF3A1"),
                   LocationId = Guid.Parse("84A3DFE2-4C08-4E18-9156-7452E556C1DD"),
                   PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

               },

               new Vehicle()
               {
                   Id = Guid.Parse("ADAC99FC-A75F-4AF4-9F1E-3570D67E6017"),
                   Make = "Audi",
                   Model = "Q8",
                   Price = 95000,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2020",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 75,
                   HorsePower = 286,
                   Cubage = 3000,
                   ImageUrl = "https://pictures.dealer.com/r/rockvilleaudiaoa/1813/530e70010e6e34ac80d27f60876ab89ex.jpg",
                   TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                   CategoryId = Guid.Parse("2FC4C7E6-CAD0-4190-95B5-78A7420A1631"),
                   LocationId = Guid.Parse("48141D40-A443-4EDF-AA93-80A12DB8690E"),
                   PurposeId = Guid.Parse("B5877ED2-BB7A-4A22-BE82-6DB9308CD2B7")

               },

               new Vehicle()
               {
                   Id = Guid.Parse("194AE085-CC33-46C6-923E-C44A5E14D4DF"),
                   Make = "Audi",
                   Model = "Q7",
                   Price = 50000,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2018",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 75,
                   HorsePower = 286,
                   Cubage = 3000,
                   ImageUrl = "https://media.ed.edmunds-media.com/audi/q7/2018/oem/2018_audi_q7_4dr-suv_30t-prestige-quattro_fq_oem_1_1600.jpg",
                   TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                   CategoryId = Guid.Parse("2FC4C7E6-CAD0-4190-95B5-78A7420A1631"),
                   LocationId = Guid.Parse("95D16D5B-0EDB-46ED-9ABC-822545A05860"),
                   PurposeId = Guid.Parse("B5877ED2-BB7A-4A22-BE82-6DB9308CD2B7")

               },

               new Vehicle()
               {
                   Id = Guid.Parse("09CE8F2C-F974-4E36-8093-CE3AA7376CF2"),
                   Make = "BMW",
                   Model = "750",
                   Price = 90000,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2019",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 80,
                   HorsePower = 400,
                   Cubage = 4000,
                   ImageUrl = "https://www.sherifo.lt/_next/image?url=https%3A%2F%2Fproduction-carloading-api-media.s3.amazonaws.com%2Flot_image%/2F1_S1ptd2M.png.1920x1080_q85.png&w=3840&q=75",
                   TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                   CategoryId = Guid.Parse("4012CBAB-8211-4C37-8566-F73F083E999F"),
                   LocationId = Guid.Parse("3CB2B945-5FB2-4489-805E-B879154902A6"),
                   PurposeId = Guid.Parse("B5877ED2-BB7A-4A22-BE82-6DB9308CD2B7")

               },

               new Vehicle()
               {
                   Id = Guid.Parse("A89B2858-EA73-4338-8E02-18D01AE2B008"),
                   Make = "Audi",
                   Model = "Q7",
                   Price = 55000,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2018",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 75,
                   HorsePower = 286,
                   Cubage = 3000,
                   ImageUrl = "https://cdn.dealerspike.com/imglib/v1/800x600/imglib/Assets/Inventory/A6/07/A6070369-F91B-47F8-9FA9-93AEF34C7EB4.jpg",
                   TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                   CategoryId = Guid.Parse("2FC4C7E6-CAD0-4190-95B5-78A7420A1631"),
                   LocationId = Guid.Parse("AE187B67-ABD1-4C1A-8590-6A22C6DE4B17"),
                   PurposeId = Guid.Parse("B5877ED2-BB7A-4A22-BE82-6DB9308CD2B7")

               },

                new Vehicle()
                {
                    Id = Guid.Parse("60B708CE-D98A-4C51-A39A-05A50FDDF989"),
                    Make = "RAM",
                    Model = "1500",
                    Price = 45000,
                    FuelType = "Бензин",
                    GearBox = "Автоматична",
                    Year = "2018",
                    Doors = 4,
                    Seats = 6,
                    TankCapacity = 90,
                    HorsePower = 395,
                    Cubage = 5700,
                    ImageUrl = "https://di-uploads-pod12.dealerinspire.com/universitydodgeram/uploads/2017/11/2018Ram1500_UniversityDodge.jpg",
                    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                    CategoryId = Guid.Parse("2FC4C7E6-CAD0-4190-95B5-78A7420A1631"),
                    LocationId = Guid.Parse("84A3DFE2-4C08-4E18-9156-7452E556C1DD"),
                    PurposeId = Guid.Parse("661D2044-185A-4911-8864-1285C0638E09")

                },

                new Vehicle()
                {
                    Id = Guid.Parse("07A52DD4-BA04-448D-80B9-0730A0716A24"),
                    Make = "Mini",
                    Model = "Countryman",
                    Price = 18000,
                    FuelType = "Дизел",
                    GearBox = "Автоматична",
                    Year = "2020",
                    Doors = 4,
                    Seats = 5,
                    TankCapacity = 50,
                    HorsePower = 116,
                    Cubage = 1500,
                    ImageUrl = "https://www.carpixel.net/w/a38025585b428caf0a5e472b1da228bb/minicooper-/s-countryman-car-wallpaper-101089.jpg",
                    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                    CategoryId = Guid.Parse("2FC4C7E6-CAD0-4190-95B5-78A7420A1631"),
                    LocationId = Guid.Parse("48141D40-A443-4EDF-AA93-80A12DB8690E"),
                    PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

                },
                new Vehicle()
                {
                    Id = Guid.Parse("5149FB0C-D53E-4ECC-BEA2-9D005EDBBDD4"),
                    Make = "Dacia",
                    Model = "Duster",
                    Price = 23000,
                    FuelType = "Дизел",
                    GearBox = "Автоматична",
                    Year = "2021",
                    Doors = 4,
                    Seats = 5,
                    TankCapacity = 50,
                    HorsePower = 116,
                    Cubage = 1500,
                    ImageUrl = "https://www.elcarrocolombiano.com/wp-contentuploads/2020/03/20200304-/RENAULT-DUSTER-2021-PRECIO-CARACTERISTICAS-EN-BRASIL-01.jpg",
                    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                    CategoryId = Guid.Parse("2FC4C7E6-CAD0-4190-95B5-78A7420A1631"),
                    LocationId = Guid.Parse("95D16D5B-0EDB-46ED-9ABC-822545A05860"),
                    PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

                },

                new Vehicle()
                {
                    Id = Guid.Parse("3CF850A3-2278-4A70-AF61-157BC9E9F69A"),
                    Make = "Toyota",
                    Model = "Corolla",
                    Price = 19000,
                    FuelType = "Бензин",
                    GearBox = "Автоматична",
                    Year = "2016",
                    Doors = 4,
                    Seats = 5,
                    TankCapacity = 55,
                    HorsePower = 132,
                    Cubage = 1600,
                    ImageUrl = "https://www.avtotachki.com/wp-content/uploads/2020/11/toyota-corolla-2016-1024x685.jpg",
                    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                    CategoryId = Guid.Parse("4012CBAB-8211-4C37-8566-F73F083E999F"),
                    LocationId = Guid.Parse("3CB2B945-5FB2-4489-805E-B879154902A6"),
                    PurposeId = Guid.Parse("8ACDD8A8-FFAA-425D-934E-D13DEAEA1836")

                },

                new Vehicle()
                {
                    Id = Guid.Parse("3C3F2CB0-FB06-4616-8396-3AAD20B6D7A6"),
                    Make = "Citroen",
                    Model = "C5",
                    Price = 16000,
                    FuelType = "Дизел",
                    GearBox = "Автоматична",
                    Year = "2016",
                    Doors = 4,
                    Seats = 5,
                    TankCapacity = 70,
                    HorsePower = 150,
                    Cubage = 2000,
                    ImageUrl = "https://s3.eu-west-2.amazonaws.com/assets.synetiq-auctions.co.uk/images/items/0026/0453805/cmih8vnjwohimemf7dj6fo5yqu6f5fsm9f52025a.jpg",
                    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                    CategoryId = Guid.Parse("939D5A93-8D55-4EC3-B3AC-39A36CD1FF29"),
                    LocationId = Guid.Parse("AE187B67-ABD1-4C1A-8590-6A22C6DE4B17"),
                    PurposeId = Guid.Parse("8ACDD8A8-FFAA-425D-934E-D13DEAEA1836")

                },

                new Vehicle()
                {
                    Id = Guid.Parse("6C57E66B-4AD8-445C-BA76-1408B86AD7FB"),
                    Make = "Hyundai",
                    Model = "i10",
                    Price = 10000,
                    FuelType = "Дизел",
                    GearBox = "Автоматична",
                    Year = "2017",
                    Doors = 4,
                    Seats = 5,
                    TankCapacity = 40,
                    HorsePower = 75,
                    Cubage = 1200,
                    ImageUrl = "https://www.avtotachki.com/wp-content/uploads/2020/12/hyundai-i10-2017-1024x640.jpg",
                    TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                    CategoryId = Guid.Parse("BD91BF4E-67A8-40B4-A992-AE31C76DF3A1"),
                    LocationId = Guid.Parse("84A3DFE2-4C08-4E18-9156-7452E556C1DD"),
                    PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

                },

               new Vehicle()
               {
                   Id = Guid.Parse("3CCB56A9-4A35-4221-BE4C-A8757D297461"),
                   Make = "Hyundai",
                   Model = "i10",
                   Price = 10500,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2017",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 40,
                   HorsePower = 75,
                   Cubage = 1200,
                   ImageUrl = "https://www.auto-data.net/images/f11/Hyundai-Grand-i10-facelift-2017.jpg",
                   TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                   CategoryId = Guid.Parse("BD91BF4E-67A8-40B4-A992-AE31C76DF3A1"),
                   LocationId = Guid.Parse("48141D40-A443-4EDF-AA93-80A12DB8690E"),
                   PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

               },

               new Vehicle()
               {
                   Id = Guid.Parse("C42C760D-0E3E-4194-A88E-7318A084FAAB"),
                   Make = "Dacia",
                   Model = "Duster",
                   Price = 25000,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2021",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 50,
                   HorsePower = 116,
                   Cubage = 1500,
                   ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c2/2018_Dacia_Duster_Comfort_1.6.jpg",
                   TypeId = Guid.Parse("912D4786-5CE9-4DC7-8DA8-47CE8FB72BEF"),
                   CategoryId = Guid.Parse("2FC4C7E6-CAD0-4190-95B5-78A7420A1631"),
                   LocationId = Guid.Parse("95D16D5B-0EDB-46ED-9ABC-822545A05860"),
                   PurposeId = Guid.Parse("F140B03D-B93A-47E6-A58A-346FAD8599AD")

               },
               new Vehicle()
               {
                   Id = Guid.Parse("204E50C5-56B3-492D-BDCB-E0F4E7CC3E93"),
                   Make = "Daf",
                   Model = "XF 480",
                   Price = 85000,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2020",
                   Doors = 2,
                   Seats = 2,
                   TankCapacity = 1100,
                   HorsePower = 480,
                   Cubage = 13000,
                   ImageUrl = "https://d2e5b8shawuel2.cloudfront.net/vehicle/304240/hlv/original.jpg",
                   TypeId = Guid.Parse("F7FA7488-E482-493D-A27C-1F1A7D38F79B"),
                   CategoryId = Guid.Parse("5E2E101C-27C9-4B94-B2E8-8F2154A4389B"),
                   LocationId = Guid.Parse("3CB2B945-5FB2-4489-805E-B879154902A6"),
                   PurposeId = Guid.Parse("661D2044-185A-4911-8864-1285C0638E09")

               },
               new Vehicle()
               {
                   Id = Guid.Parse("D3C87FC7-8F2E-4385-88CF-750802A00157"),
                   Make = "Mercedes-Benz",
                   Model = "Actros",
                   Price = 35000,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2017",
                   Doors = 2,
                   Seats = 2,
                   TankCapacity = 900,
                   HorsePower = 450,
                   Cubage = 12800,
                   ImageUrl = "https://st.mascus.com/imagetilewm/product/e5a8342d/mercedes-benz-actros-1846-ls,5897e6b7-1.jpg",
                   TypeId = Guid.Parse("F7FA7488-E482-493D-A27C-1F1A7D38F79B"),
                   CategoryId = Guid.Parse("5E2E101C-27C9-4B94-B2E8-8F2154A4389B"),
                   LocationId = Guid.Parse("AE187B67-ABD1-4C1A-8590-6A22C6DE4B17"),
                   PurposeId = Guid.Parse("661D2044-185A-4911-8864-1285C0638E09")

               },
               new Vehicle()
               {
                   Id = Guid.Parse("99EC8DB1-B331-452C-A22E-1CB72D05379F"),
                   Make = "Iveco",
                   Model = "35c18",
                   Price = 42000,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2018",
                   Doors = 2,
                   Seats = 3,
                   TankCapacity = 120,
                   HorsePower = 180,
                   Cubage = 3000,
                   ImageUrl = "https://d2e5b8shawuel2.cloudfront.net/vehicle/285996/hlv/original.jpg",
                   TypeId = Guid.Parse("8F40D349-C104-430E-81D4-AB1BA6390187"),
                   CategoryId = Guid.Parse("247C145D-9B6D-4315-A68A-F8191B687429"),
                   LocationId = Guid.Parse("84A3DFE2-4C08-4E18-9156-7452E556C1DD"),
                   PurposeId = Guid.Parse("661D2044-185A-4911-8864-1285C0638E09")

               },
               new Vehicle()
               {
                   Id = Guid.Parse("F2D53339-77A9-4D2A-A1BD-BD7AB0E07E26"),
                   Make = "Mercedes-Benz",
                   Model = "Sprinter 316",
                   Price = 32000,
                   FuelType = "Дизел",
                   GearBox = "Ръчна",
                   Year = "2015",
                   Doors = 3,
                   Seats = 8,
                   TankCapacity = 100,
                   HorsePower = 163,
                   Cubage = 2200,
                   ImageUrl = "https://d2e5b8shawuel2.cloudfront.net/vehicle/284390/hlv/original.jpg",
                   TypeId = Guid.Parse("8F40D349-C104-430E-81D4-AB1BA6390187"),
                   CategoryId = Guid.Parse("247C145D-9B6D-4315-A68A-F8191B687429"),
                   LocationId = Guid.Parse("48141D40-A443-4EDF-AA93-80A12DB8690E"),
                   PurposeId = Guid.Parse("661D2044-185A-4911-8864-1285C0638E09")

               },
               new Vehicle()
               {
                   Id = Guid.Parse("A80BDD96-7A9E-49C1-BE7B-BD7A371051ED"),
                   Make = "Renault",
                   Model = "Master",
                   Price = 32000,
                   FuelType = "Дизел",
                   GearBox = "Ръчна",
                   Year = "2018",
                   Doors = 3,
                   Seats = 17,
                   TankCapacity = 130,
                   HorsePower = 143,
                   Cubage = 2300,
                   ImageUrl = "https://ppdobrich.com/uploads/thumbnail/preoborudvan-mikrobus-reno-master-c880x465.jpg",
                   TypeId = Guid.Parse("8F40D349-C104-430E-81D4-AB1BA6390187"),
                   CategoryId = Guid.Parse("247C145D-9B6D-4315-A68A-F8191B687429"),
                   LocationId = Guid.Parse("95D16D5B-0EDB-46ED-9ABC-822545A05860"),
                   PurposeId = Guid.Parse("661D2044-185A-4911-8864-1285C0638E09")

               },
            };

            return vehicles;
        }
    }
}