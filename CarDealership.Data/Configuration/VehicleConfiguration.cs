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
               new Vehicle()
               {
                   Make = "Mercedes-Benz",
                   Model = "S 500",
                   Price = 80000,
                   FuelType = "Бензин",
                   GearBox = "Автоматична",
                   Year = "2016",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 90,
                   HorsePower = 455,
                   Cubage = 5000,
                   ImageUrl = "https://editorial.pxcrush.net/carsales/general/editorial/ge5710401472975685544.jpg?width=1024&height=682",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("89253114-1117-481A-94C8-C93E798C73F3"),
                   LocationId = Guid.Parse( "30B08E92-62DE-42F7-B345-ACA315DFD54A"),
                   PurposeId = Guid.Parse("5999E3DB-7948-47AB-A2B7-2AA0393AD07E")

               },
               new Vehicle()
               {
                   Make = "BMW",
                   Model = "760",
                   Price = 180000,
                   FuelType = "Бензин",
                   GearBox = "Автоматична",
                   Year = "2019",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 100,
                   HorsePower = 609,
                   Cubage = 6000,
                   ImageUrl = "https://a4d540d8508d4f8a94eefc64d221e3d5.objectstore.eu/lot-20087413/1000x0/94a340b554216b7d5753cdc44dc7217c.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("89253114-1117-481A-94C8-C93E798C73F3"),
                   LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F064"),
                   PurposeId = Guid.Parse("5999E3DB-7948-47AB-A2B7-2AA0393AD07E")

               },
               new Vehicle()
               {
                   Make = "Audi",
                   Model = "A8",
                   Price = 90000,
                   FuelType = "Бензин",
                   GearBox = "Автоматична",
                   Year = "2018",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 90,
                   HorsePower = 340,
                   Cubage = 3000,
                   ImageUrl = "https://a4d540d8508d4f8a94eefc64d221e3d5.objectstore.eu/ lot-19801563/1000x0/d00867bc670fa9c6fcae88c376ab6628.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("89253114-1117-481A-94C8-C93E798C73F3"),
                   LocationId = Guid.Parse("928C42CE-F6CF-4A56-8EB0-08D9BD65F99A"),
                   PurposeId = Guid.Parse("5999E3DB-7948-47AB-A2B7-2AA0393AD07E")

               },
               new Vehicle()
               {
                   Make = "Mercedes-Benz",
                   Model = "S 350",
                   Price = 100000,
                   FuelType = "Бензин",
                   GearBox = "Автоматична",
                   Year = "2020",
                   Doors = 2,
                   Seats = 4,
                   TankCapacity = 70,
                   HorsePower = 299,
                   Cubage = 2000,
                   ImageUrl = "https://www.inghamdriven.nz/wp-content/filesstockCNM/8098/20538_01.jpg?//  width=2048&optimize=medium",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("7AE247D2-AF02-4D12-8531-AEC70481EC82"),
                   LocationId = Guid.Parse("47C0D9B6-FF78-4C4B-8872-14F12E12F024"),
                   PurposeId = Guid.Parse("5999E3DB-7948-47AB-A2B7-2AA0393AD07E")

               },
               new Vehicle()
               {
                   Make = "Porsche",
                   Model = "911 Turbo S",
                   Price = 270000,
                   FuelType = "Бензин",
                   GearBox = "Автоматична",
                   Year = "2014",
                   Doors = 2,
                   Seats = 4,
                   TankCapacity = 80,
                   HorsePower = 560,
                   Cubage = 3800,
                   ImageUrl = "https://www.perfectautocollection.com/imagetag/3466/2/l/Used-2014-  Porsche-911-Turbo-S-1722623538.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("BBCEE395-3C50-4B16-8C6B-078997031124"),
                   LocationId = Guid.Parse("30B08E92-62DE-42F7-B345-ACA315DFD54A"),
                   PurposeId = Guid.Parse("5999E3DB-7948-47AB-A2B7-2AA0393AD07E")

               },
                new Vehicle()
                {
                  Make = "Land Rover",
                  Model = "Defender",
                  Price = 160000,
                  FuelType = "Дизел",
                  GearBox = "Автоматична",
                  Year = "2023",
                  Doors = 4,
                  Seats = 5,
                  TankCapacity = 95,
                  HorsePower = 250,
                  Cubage = 3000,
                  ImageUrl = "https://www.southeastautoshowroom.com/imagetag/1492/mainlUsed-2023Land-/Rover-Defender-110-X-1682620154.jpg",
                  TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                  CategoryId = Guid.Parse("A9F48DE6-0FEB-4B5F-8585-BFFAC93E5041"),
                  LocationId = Guid.Parse("683F4284-6138-4DCE-9191-32206DFD442E"),
                  PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

                },
                new Vehicle()
                {
                  Make = "Audi",
                  Model = "RS6",
                  Price = 110000,
                  FuelType = "Бензин",
                  GearBox = "Автоматична",
                  Year = "2016",
                  Doors = 4,
                  Seats = 5,
                  TankCapacity = 100,
                  HorsePower = 605,
                  Cubage = 4000,
                  ImageUrl = "https://gtspirit.com/wp-content/uploads/2015/05/Audi-RS6-Avant-2.jpg",
                  TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                  CategoryId = Guid.Parse("8D5DD07E-CEFE-45C2-8266-C28946A99400"),
                  LocationId = Guid.Parse("47C0D9B6-FF78-4C4B-8872-14F12E12F024"),
                  PurposeId = Guid.Parse("5999E3DB-7948-47AB-A2B7-2AA0393AD07E")

                },
                new Vehicle()
                {
                  Make = "Bentley",
                  Model = "Continental GT",
                  Price = 470000,
                  FuelType = "Бензин",
                  GearBox = "Автоматична",
                  Year = "2022",
                  Doors = 2,
                  Seats = 4,
                  TankCapacity = 100,
                  HorsePower = 549,
                  Cubage = 4000,
                  ImageUrl = "https://www.carpixel.netw/3606b3152f8facfae42a639f23b09c95bentleycontinental-gt-s-wallpaperhd-109039.jpg",
                  TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                  CategoryId = Guid.Parse("BBCEE395-3C50-4B16-8C6B-078997031124"),
                  LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F064"),
                  PurposeId = Guid.Parse("5999E3DB-7948-47AB-A2B7-2AA0393AD07E")

                },
                new Vehicle()
                {
                  Make = "Aston martin",
                  Model = "DBS",
                  Price = 500000,
                  FuelType = "Бензин",
                  GearBox = "Автоматична",
                  Year = "2022",
                  Doors = 2,
                  Seats = 4,
                  TankCapacity = 120,
                  HorsePower = 639,
                  Cubage = 5200,
                  ImageUrl = "https://www.astonmartinwashingtondc.comimagetag/3371/3lNew-2022Aston-Martin-DBS-Superleggera-1664901853.jpg",
                  TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                  CategoryId = Guid.Parse("BBCEE395-3C50-4B16-8C6B-078997031124"),
                  LocationId = Guid.Parse("47C0D9B6-FF78-4C4B-8872-14F12E12F024"),
                  PurposeId = Guid.Parse("5999E3DB-7948-47AB-A2B7-2AA0393AD07E")

                },
                new Vehicle()
                {
                    Make = "Fiat",
                    Model = "Talento",
                    Price = 18999,
                    FuelType = "Дизел",
                    GearBox = "Ръчна",
                    Year = "2017",
                    Doors = 4,
                    Seats = 3,
                    TankCapacity = 70,
                    HorsePower = 120,
                    Cubage = 1600,
                    ImageUrl = "https://static-eu.cargurus.com/images/forsale/2024/09/11/21/37/2018_fiat_talento-pic-8046155731279073145-1024x768.jpeg",
                    TypeId = Guid.Parse("8474C958-2F28-47D2-9878-D7ECA96EE0D4"),
                    CategoryId = Guid.Parse("0E706B47-5378-48E6-B7DF-21E2B1D32901"),
                    LocationId = Guid.Parse("683F4284-6138-4DCE-9191-32206DFD442E"),
                    PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

                },
                new Vehicle()
                {
                    Make = "Ford",
                    Model = "Transit",
                    Price = 27000,
                    FuelType = "Дизел",
                    GearBox = "Ръчна",
                    Year = "2019",
                    Doors = 4,
                    Seats = 3,
                    TankCapacity = 90,
                    HorsePower = 130,
                    Cubage = 2000,
                    ImageUrl = "https://images.clickdealer.co.uk/vehicles/4175/4175102/large2/92193323.jpg",
                    TypeId = Guid.Parse("8474C958-2F28-47D2-9878-D7ECA96EE0D4"),
                    CategoryId = Guid.Parse("0E706B47-5378-48E6-B7DF-21E2B1D32901"),
                    LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F064"),
                    PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

                },
                new Vehicle()
                {
                    Make = "Daf",
                    Model = "XF 408",
                    Price = 88999,
                    FuelType = "Дизел",
                    GearBox = "Автоматична",
                    Year = "2020",
                    Doors = 2,
                    Seats = 2,
                    TankCapacity = 1200,
                    HorsePower = 480,
                    Cubage = 13000,
                    ImageUrl = "https://www.truck1.bg/img/Vlekach_DAF_XF_480_FT_EURO_6_ADR-xxl-8235/8235_5044513319890.jpg",
                    TypeId = Guid.Parse("372DDED3-031B-4892-B74B-7B4853D68603"),
                    CategoryId = Guid.Parse("D5A8ECE2-9696-42AE-94E5-30319050DA93"),
                    LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F064"),
                    PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

                },
                new Vehicle()
                {
                    Make = "Ford",
                    Model = "Ranger",
                    Price = 27000,
                    FuelType = "Дизел",
                    GearBox = "Ръчка",
                    Year = "2012",
                    Doors = 4,
                    Seats = 5,
                    TankCapacity = 80,
                    HorsePower = 150,
                    Cubage = 2200,
                    ImageUrl = "https://abstoragev4.blob.core.windows.net/auctions/39678/cars/medium/39678-1_ex.jpg",
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("94E34E27-1DBD-4D96-B3F2-7BC799CC2853"),
                    LocationId = Guid.Parse("30B08E92-62DE-42F7-B345-ACA315DFD54A"),
                    PurposeId = Guid.Parse("E1A23BD8-CA1F-43F1-A73E-63DBD887FC20")

                },
                new Vehicle()
                {
                    Make = "Citroen",
                    Model = "Berlingo",
                    Price = 9000,
                    FuelType = "Дизел",
                    GearBox = "Ръчна",
                    Year = "2014",
                    Doors = 2,
                    Seats = 2,
                    TankCapacity = 60,
                    HorsePower = 92,
                    Cubage = 1600,
                    ImageUrl = "https://wallpapers.com/images/hd/caption-stylish-citroen-berlingoonthe-//open-road-r6rrgptqhdh95zwh.jpg",
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("E091F5BB-8030-47C1-BF33-4856DF0D905E"),
                    LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F064x"),
                    PurposeId = Guid.Parse("E1A23BD8-CA1F-43F1-A73E-63DBD887FC20")

                },
               new Vehicle()
               {
                   Make = "Audi",
                   Model = "A4",
                   Price = 1100,
                   FuelType = "Бензин",
                   GearBox = "Автоматична",
                   Year = "2010",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 70,
                   HorsePower = 210,
                   Cubage = 2000,
                   ImageUrl = "https://imgr1.auto-motor-und-sport.de/Audi-A4-Avant-1-8TFSIreact169Big-//f606376d-384773.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("8D5DD07E-CEFE-45C2-8266-C28946A99400"),
                   LocationId = Guid.Parse("47C0D9B6-FF78-4C4B-8872-14F12E12F024"),
                   PurposeId = Guid.Parse("EDD96E69-2979-4813-99C3-5EDE5304D595")

               },
               new Vehicle()
               {
                   Make = "Citroen",
                   Model = "Berlingo",
                   Price = 9000,
                   FuelType = "Дизел",
                   GearBox = "Ръчна",
                   Year = "2014",
                   Doors = 2,
                   Seats = 2,
                   TankCapacity = 60,
                   HorsePower = 92,
                   Cubage = 1600,
                   ImageUrl = "https://wallpapers.com/images/hd/caption-stylish-citroen-berlingo-onthe-/open-road-r6rrgptqhdh95zwh.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("E091F5BB-8030-47C1-BF33-4856DF0D905E"),
                   LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F064"),
                   PurposeId = Guid.Parse("E1A23BD8-CA1F-43F1-A73E-63DBD887FC20")

               },
               new Vehicle()
               {
                   Make = "Dacia",
                   Model = "Sandero",
                   Price = 16000,
                   FuelType = "Бензин",
                   GearBox = "Автоматична",
                   Year = "2018",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 60,
                   HorsePower = 90,
                   Cubage = 1000,
                   ImageUrl = "https://img-pa.auto1.com/img53/7a/537a451e1e8592af996df6d02497ae30/pa/FZ44914_961889bcd6782481a45aec95c890dda7.jpeg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("F4216B8C-F6E0-40A8-8A6A-AE0534601801"),
                   LocationId = Guid.Parse("47C0D9B6-FF78-4C4B-8872-14F12E12F024"),
                   PurposeId = Guid.Parse("790C2F30-A75A-45A2-85A7-6F9075A35135")

               },
               new Vehicle()
               {
                   Make = "Jaguar",
                   Model = "XF",
                   Price = 23500,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2018",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 80,
                   HorsePower = 244,
                   Cubage = 3000,
                   ImageUrl = "https://www.motorbeam.com/wp-content/uploads/Jaguar-XF-Diesel-Review-1200x900.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("89253114-1117-481A-94C8-C93E798C73F3"),
                   LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F064"),
                   PurposeId = Guid.Parse("E1A23BD8-CA1F-43F1-A73E-63DBD887FC20")

               },
               new Vehicle()
               {
                   Make = "Honda",
                   Model = "Cr-v",
                   Price = 24500,
                   FuelType = "Дизел",
                   GearBox = "Ръчна",
                   Year = "2015",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 70,
                   HorsePower = 150,
                   Cubage = 2200,
                   ImageUrl = "https://media.ed.edmunds-media.com/honda/cr-v/2015/oem/2015_honda_cr-v_4dr-suv_touring_fq_oem_1_1600.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("A9F48DE6-0FEB-4B5F-8585-BFFAC93E5041"),
                   LocationId = Guid.Parse("30B08E92-62DE-42F7-B345-ACA315DFD54A"),
                   PurposeId = Guid.Parse("E1A23BD8-CA1F-43F1-A73E-63DBD887FC20")

               },
               new Vehicle()
               {
                   Make = "Opel",
                   Model = "Meriva",
                   Price = 2500,
                   FuelType = "Дизел",
                   GearBox = "Ръчна",
                   Year = "2004",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 60,
                   HorsePower = 75,
                   Cubage = 1700,
                   ImageUrl = "https://img.autoabc.lv/opel-meriva/opel-meriva_2003_Minivens_1512150409_4.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("BBCEE395-3C50-4B16-8C6B-078997031124"),
                   LocationId = Guid.Parse("928C42CE-F6CF-4A56-8EB0-08D9BD65F99A"),
                   PurposeId = Guid.Parse("1E33C1B2-1C29-4EC3-8907-FBAAE15A61F5")

               },
               new Vehicle()
               {
                   Make = "Volkswagen",
                   Model = "Passat",
                   Price = 35500,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2020",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 65,
                   HorsePower = 240,
                   Cubage = 2000,
                   ImageUrl = "https://cdn.jdpower.com/JDPA_2020%20Volkswagen%20Passat%20R-Li%/20Aurora/%20Red%20Front%20View%20Small_edited.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("89253114-1117-481A-94C8-C93E798C73F3"),
                   LocationId = Guid.Parse("47C0D9B6-FF78-4C4B-8872-14F12E12F024"),
                   PurposeId = Guid.Parse("E1A23BD8-CA1F-43F1-A73E-63DBD887FC20")

               },

                new Vehicle()
                {
                    Make = "Skoda",
                    Model = "Octavia",
                    Price = 22500,
                    FuelType = "Дизел",
                    GearBox = "Автоматична",
                    Year = "2017",
                    Doors = 4,
                    Seats = 5,
                    TankCapacity = 60,
                    HorsePower = 185,
                    Cubage = 2000,
                    ImageUrl = "https://automedia.investor.bg/media/files/resizeduploadedfiles/640x0//b26/c230bdb3a7c8e9242f83577101b65b26-1920px-2018-skoda-octavia-5emy185-110tsi-/station-wagon-2018-11-02.jpg",
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("8D5DD07E-CEFE-45C2-8266-C28946A99400"),
                    LocationId = Guid.Parse("30B08E92-62DE-42F7-B345-ACA315DFD54A"),
                    PurposeId = Guid.Parse("13ABD18E-8941-4102-ACE6-E02EE85B97E3")

                },

                new Vehicle()
                {
                    Make = "Peugeot",
                    Model = "307",
                    Price = 5500,
                    FuelType = "Дизел",
                    GearBox = "Автоматична",
                    Year = "2009",
                    Doors = 2,
                    Seats = 4,
                    TankCapacity = 50,
                    HorsePower = 136,
                    Cubage = 2000,
                    ImageUrl = "https://www.auto-data.net/images/f21/Peugeot-307-facelift-2005.jpg",
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("F4216B8C-F6E0-40A8-8A6A-AE0534601801"),
                    LocationId = Guid.Parse("928C42CE-F6CF-4A56-8EB0-08D9BD65F99A"),
                    PurposeId = Guid.Parse("790C2F30-A75A-45A2-85A7-6F9075A35135")

                },

                new Vehicle()
                {
                    Make = "Renault",
                    Model = "Kadjar",
                    Price = 19500,
                    FuelType = "Дизел",
                    GearBox = "Автоматична",
                    Year = "2017",
                    Doors = 4,
                    Seats = 5,
                    TankCapacity = 65,
                    HorsePower = 130,
                    Cubage = 1600,
                    ImageUrl = "https://images.clickdealer.co.uk/vehicles/5611/5611012/large1/131132474.jpg",
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("A9F48DE6-0FEB-4B5F-8585-BFFAC93E5041"),
                    LocationId = Guid.Parse("683F4284-6138-4DCE-9191-32206DFD442E"),
                    PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

                },

                new Vehicle()
                {
                    Make = "Volkswagen",
                    Model = "Scirocco",
                    Price = 9500,
                    FuelType = "Дизел",
                    GearBox = "Автоматична",
                    Year = "2013",
                    Doors = 2,
                    Seats = 4,
                    TankCapacity = 55,
                    HorsePower = 140,
                    Cubage = 2000,
                    ImageUrl = "https://www.motortrend.com/uploads/sites/5/2013/11/2013-Volkswagen-Scirocco-R-front-three-quarters1.jpg",
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("BBCEE395-3C50-4B16-8C6B-078997031124"),
                    LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F064"),
                    PurposeId = Guid.Parse("1E33C1B2-1C29-4EC3-8907-FBAAE15A61F5")

                },

               new Vehicle()
               {
                   Make = "Volkswagen",
                   Model = "Golf",
                   Price = 12500,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2013",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 50,
                   HorsePower = 110,
                   Cubage = 1600,
                   ImageUrl = "https://media.stockmanager.ie/media/0380e15958fbd2bb2c34655d332a20d1.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("F4216B8C-F6E0-40A8-8A6A-AE0534601801"),
                   LocationId = Guid.Parse("47C0D9B6-FF78-4C4B-8872-14F12E12F024"),
                   PurposeId = Guid.Parse("790C2F30-A75A-45A2-85A7-6F9075A35135")

               },
               new Vehicle()
               {
                   Make = "Toyota",
                   Model = "Auris",
                   Price = 13000,
                   FuelType = "Дизел",
                   GearBox = "Ръчни",
                   Year = "2013",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 50,
                   HorsePower = 90,
                   Cubage = 1400,
                   ImageUrl = "https://aaaautoeuimg.vshcdn.net/thumb/900482724_640x480x95.jpg?58802",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("8D5DD07E-CEFE-45C2-8266-C28946A99400"),
                   LocationId = Guid.Parse("928C42CE-F6CF-4A56-8EB0-08D9BD65F99A"),
                   PurposeId = Guid.Parse("13ABD18E-8941-4102-ACE6-E02EE85B97E3")

               },

               new Vehicle()
               {
                   Make = "Opel",
                   Model = "Mokka",
                   Price = 23000,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2020",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 45,
                   HorsePower = 110,
                   Cubage = 1500,
                   ImageUrl = "https://autobild.bg/wp-content/uploads/2021/09/IMG_5826.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("A9F48DE6-0FEB-4B5F-8585-BFFAC93E5041"),
                   LocationId = Guid.Parse("30B08E92-62DE-42F7-B345-ACA315DFD54A"),
                   PurposeId = Guid.Parse("1E33C1B2-1C29-4EC3-8907-FBAAE15A61F5")

               },

               new Vehicle()
               {
                   Make = "Volkswagen",
                   Model = "Sharan",
                   Price = 15000,
                   FuelType = "Дизел",
                   GearBox = "Автоматична",
                   Year = "2012",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 70,
                   HorsePower = 140,
                   Cubage = 2000,
                   ImageUrl = "https://cdn3.riastatic.com/photos/ir/new/auto/photo/volkswagen_sharan__344776878-620x415x70.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("E091F5BB-8030-47C1-BF33-4856DF0D905E"),
                   LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F064"),
                   PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

               },

               new Vehicle()
               {
                   Make = "Peugeot",
                   Model = "208",
                   Price = 9000,
                   FuelType = "Бензин",
                   GearBox = "Автоматична",
                   Year = "2015",
                   Doors = 4,
                   Seats = 5,
                   TankCapacity = 50,
                   HorsePower = 110,
                   Cubage = 1200,
                   ImageUrl = "https://cloud.leparking.fr/2021/04/27/00/23/peugeot-208-peugeot-208-2015-67000km-garantie-inconnu_8085850837.jpg",
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("F4216B8C-F6E0-40A8-8A6A-AE0534601801"),
                   LocationId = Guid.Parse("683F4284-6138-4DCE-9191-32206DFD442E"),
                   PurposeId = Guid.Parse("1E33C1B2-1C29-4EC3-8907-FBAAE15A61F5")

               },

               new Vehicle()
               {
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
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("F4216B8C-F6E0-40A8-8A6A-AE0534601801"),
                   LocationId = Guid.Parse("47C0D9B6-FF78-4C4B-8872-14F12E12F024"),
                   PurposeId = Guid.Parse("1E33C1B2-1C29-4EC3-8907-FBAAE15A61F5")

               },
               new Vehicle()
               {
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
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("F4216B8C-F6E0-40A8-8A6A-AE0534601801"),
                   LocationId = Guid.Parse("928C42CE-F6CF-4A56-8EB0-08D9BD65F99A"),
                   PurposeId = Guid.Parse("790C2F30-A75A-45A2-85A7-6F9075A35135")

               },

               new Vehicle()
               {
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
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("A9F48DE6-0FEB-4B5F-8585-BFFAC93E5041"),
                   LocationId = Guid.Parse("30B08E92-62DE-42F7-B345-ACA315DFD54A"),
                   PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

               },

               new Vehicle()
               {
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
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("A9F48DE6-0FEB-4B5F-8585-BFFAC93E5041"),
                   LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F064"),
                   PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

               },

               new Vehicle()
               {
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
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("89253114-1117-481A-94C8-C93E798C73F3"),
                   LocationId = Guid.Parse("683F4284-6138-4DCE-9191-32206DFD442E"),
                   PurposeId = Guid.Parse("5999E3DB-7948-47AB-A2B7-2AA0393AD07E")

               },

               new Vehicle()
               {
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
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("A9F48DE6-0FEB-4B5F-8585-BFFAC93E5041"),
                   LocationId = Guid.Parse("47C0D9B6-FF78-4C4B-8872-14F12E12F024"),
                   PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

               },

                new Vehicle()
                {
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
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("A9F48DE6-0FEB-4B5F-8585-BFFAC93E5041"),
                    LocationId = Guid.Parse("928C42CE-F6CF-4A56-8EB0-08D9BD65F99A"),
                    PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

                },

                new Vehicle()
                {
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
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("A9F48DE6-0FEB-4B5F-8585-BFFAC93E5041"),
                    LocationId = Guid.Parse("30B08E92-62DE-42F7-B345-ACA315DFD54A"),
                    PurposeId = Guid.Parse("E1A23BD8-CA1F-43F1-A73E-63DBD887FC20")

                },
                new Vehicle()
                {
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
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("A9F48DE6-0FEB-4B5F-8585-BFFAC93E5041"),
                    LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F064"),
                    PurposeId = Guid.Parse("790C2F30-A75A-45A2-85A7-6F9075A35135")

                },

                new Vehicle()
                {
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
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("89253114-1117-481A-94C8-C93E798C73F3"),
                    LocationId = Guid.Parse("683F4284-6138-4DCE-9191-32206DFD442E"),
                    PurposeId = Guid.Parse("E1A23BD8-CA1F-43F1-A73E-63DBD887FC20")

                },

                new Vehicle()
                {
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
                    ImageUrl = "https://img-pa.auto1.com/imgd0/8a/d08a3dea07a8b236e71910325cec96f4pa//KS84681_2c7e1945aff6e9ae46f0916d71cee46d.jpeg",
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("8D5DD07E-CEFE-45C2-8266-C28946A99400"),
                    LocationId = Guid.Parse("47C0D9B6-FF78-4C4B-8872-14F12E12F024"),
                    PurposeId = Guid.Parse("13ABD18E-8941-4102-ACE6-E02EE85B97E3")

                },

                new Vehicle()
                {
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
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("F4216B8C-F6E0-40A8-8A6A-AE0534601801"),
                    LocationId = Guid.Parse("928C42CE-F6CF-4A56-8EB0-08D9BD65F99A"),
                    PurposeId = Guid.Parse("1E33C1B2-1C29-4EC3-8907-FBAAE15A61F5")

                },

               new Vehicle()
               {
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
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("F4216B8C-F6E0-40A8-8A6A-AE0534601801"),
                   LocationId = Guid.Parse("30B08E92-62DE-42F7-B345-ACA315DFD54A"),
                   PurposeId = Guid.Parse("1E33C1B2-1C29-4EC3-8907-FBAAE15A61F5"),

               },

               new Vehicle()
               {
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
                   TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                   CategoryId = Guid.Parse("A9F48DE6-0FEB-4B5F-8585-BFFAC93E5041"),
                   LocationId = Guid.Parse("683F4284-6138-4DCE-9191-32206DFD442E"),
                   PurposeId = Guid.Parse("790C2F30-A75A-45A2-85A7-6F9075A35135")

               },
               new Vehicle()
               {
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
                   TypeId = Guid.Parse("372DDED3-031B-4892-B74B-7B4853D68603"),
                   CategoryId = Guid.Parse("D5A8ECE2-9696-42AE-94E5-30319050DA93"),
                   LocationId = Guid.Parse("47C0D9B6-FF78-4C4B-8872-14F12E12F024"),
                   PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

               },
               new Vehicle()
               {
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
                   TypeId = Guid.Parse("372DDED3-031B-4892-B74B-7B4853D68603"),
                   CategoryId = Guid.Parse("D5A8ECE2-9696-42AE-94E5-30319050DA93"),
                   LocationId = Guid.Parse("928C42CE-F6CF-4A56-8EB0-08D9BD65F99A"),
                   PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

               },
               new Vehicle()
               {
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
                   TypeId = Guid.Parse("8474C958-2F28-47D2-9878-D7ECA96EE0D4"),
                   CategoryId = Guid.Parse("0E706B47-5378-48E6-B7DF-21E2B1D32901"),
                   LocationId = Guid.Parse("30B08E92-62DE-42F7-B345-ACA315DFD54A"),
                   PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

               },
               new Vehicle()
               {
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
                   TypeId = Guid.Parse("8474C958-2F28-47D2-9878-D7ECA96EE0D4"),
                   CategoryId = Guid.Parse("0E706B47-5378-48E6-B7DF-21E2B1D32901"),
                   LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F064"),
                   PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

               },
               new Vehicle()
               {
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
                   TypeId = Guid.Parse("8474C958-2F28-47D2-9878-D7ECA96EE0D4"),
                   CategoryId = Guid.Parse("0E706B47-5378-48E6-B7DF-21E2B1D32901"),
                   LocationId = Guid.Parse("683F4284-6138-4DCE-9191-32206DFD442E"),
                   PurposeId = Guid.Parse("545E3752-EE3A-42A4-8AD1-C1250E6BA184")

               },
            };

            return vehicles;
        }
    }
}
