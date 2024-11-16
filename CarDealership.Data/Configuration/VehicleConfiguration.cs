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
                    LocationId = Guid.Parse("30B08E92-62DE-42F7-B345-ACA315DFD54A"),
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
                    ImageUrl = "https://a4d540d8508d4f8a94eefc64d221e3d5.objectstore.eu/lot-19801563/1000x0/d00867bc670fa9c6fcae88c376ab6628.jpg",
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
                    ImageUrl = "https://www.inghamdriven.nz/wp-content/files/stock/CNM/8098/20538_01.jpg?width=2048&optimize=medium",
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
                    ImageUrl = "https://www.perfectautocollection.com/imagetag/3466/2/l/Used-2014-Porsche-911-Turbo-S-1722623538.jpg",
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
                    ImageUrl = "https://www.southeastautoshowroom.com/imagetag/1492/main/l/Used-2023-Land-Rover-Defender-110-X-1682620154.jpg",
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("A9F48DE6-0FEB-4B5F-8585-BFFAC93E5041F"),
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
                    ImageUrl = "https://www.carpixel.net/w/3606b3152f8facfae42a639f23b09c95/bentley-continental-gt-s-wallpaper-hd-109039.jpg",
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
                    ImageUrl = "https://www.astonmartinwashingtondc.com/imagetag/3371/3/l/New-2022-Aston-Martin-DBS-Superleggera-1664901853.jpg",
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
                    ImageUrl = "https://wallpapers.com/images/hd/caption-stylish-citroen-berlingo-on-the-open-road-r6rrgptqhdh95zwh.jpg",
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("E091F5BB-8030-47C1-BF33-4856DF0D905E"),
                    LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F0644"),
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
                    ImageUrl = "https://imgr1.auto-motor-und-sport.de/Audi-A4-Avant-1-8-TFSI-react169Big-f606376d-384773.jpg",
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
                    ImageUrl = "https://wallpapers.com/images/hd/caption-stylish-citroen-berlingo-on-the-open-road-r6rrgptqhdh95zwh.jpg",
                    TypeId = Guid.Parse("F6FCC477-D738-4077-B0D0-C5F5FCFDBE68"),
                    CategoryId = Guid.Parse("E091F5BB-8030-47C1-BF33-4856DF0D905E"),
                    LocationId = Guid.Parse("729897EC-6A17-4851-8831-4D2B2D04F0644"),
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
            };

            return vehicles;
        }
    }
}
