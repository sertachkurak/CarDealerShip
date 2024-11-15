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
                    TypeId = Guid.Parse("F540F085-8856-40C0-BD20-E9A75EDA7B04"),
                    CategoryId = Guid.Parse("265FCA3D-4E9C-45B9-A66B-44ED76C69F0A"),
                    LocationId = Guid.Parse("452A22F0-1F19-47A7-BA17-E70862761D6B"),
                    PurposeId = Guid.Parse("8A4593A5-DB68-4E60-9D7E-716EECF3DC90")

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
                    TypeId = Guid.Parse("F540F085-8856-40C0-BD20-E9A75EDA7B04"),
                    CategoryId = Guid.Parse("265FCA3D-4E9C-45B9-A66B-44ED76C69F0A"),
                    LocationId = Guid.Parse("CCFD06A9-5D1C-4819-B497-BDD32FACD946"),
                    PurposeId = Guid.Parse("8A4593A5-DB68-4E60-9D7E-716EECF3DC90")

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
                    TypeId = Guid.Parse("F540F085-8856-40C0-BD20-E9A75EDA7B04"),
                    CategoryId = Guid.Parse("265FCA3D-4E9C-45B9-A66B-44ED76C69F0A"),
                    LocationId = Guid.Parse("E003CB0D-1A35-4A6C-95F8-4AF614928BE6"),
                    PurposeId = Guid.Parse("8A4593A5-DB68-4E60-9D7E-716EECF3DC90")

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
                    ImageUrl = "https://www.auto-data.net/images/f13/mercedes-benz-e-class-cabrio-a238.jpg",
                    TypeId = Guid.Parse("F540F085-8856-40C0-BD20-E9A75EDA7B04"),
                    CategoryId = Guid.Parse("CCD6DB7A-6190-4B5C-887A-613765548159"),
                    LocationId = Guid.Parse("171893B6-D014-48CE-95A6-1ACB1E5CC6A9"),
                    PurposeId = Guid.Parse("765EE250-2A71-46F0-92A0-135F7F8CAA2F")

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
                    TypeId = Guid.Parse("F540F085-8856-40C0-BD20-E9A75EDA7B04"),
                    CategoryId = Guid.Parse("DAAE2DA8-A192-4D1B-9AD2-4C8CCAE60650"),
                    LocationId = Guid.Parse("452A22F0-1F19-47A7-BA17-E70862761D6B"),
                    PurposeId = Guid.Parse("8A4593A5-DB68-4E60-9D7E-716EECF3DC90")

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
                    TypeId = Guid.Parse("F540F085-8856-40C0-BD20-E9A75EDA7B04"),
                    CategoryId = Guid.Parse("56939A4A-9081-48A9-8568-603A710A755F"),
                    LocationId = Guid.Parse("D0D3A9C7-0DD2-41B8-8A53-11C206259142"),
                    PurposeId = Guid.Parse("A23D0FCF-4A84-4383-89A7-21340AF222BC")

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
                    TypeId = Guid.Parse("F540F085-8856-40C0-BD20-E9A75EDA7B04"),
                    CategoryId = Guid.Parse("5736552F-C0EF-4A59-874B-D90FF197065F"),
                    LocationId = Guid.Parse("CCFD06A9-5D1C-4819-B497-BDD32FACD946"),
                    PurposeId = Guid.Parse("8A4593A5-DB68-4E60-9D7E-716EECF3DC90")

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
                    TypeId = Guid.Parse("F540F085-8856-40C0-BD20-E9A75EDA7B04"),
                    CategoryId = Guid.Parse("DAAE2DA8-A192-4D1B-9AD2-4C8CCAE60650"),
                    LocationId = Guid.Parse("D0D3A9C7-0DD2-41B8-8A53-11C206259142"),
                    PurposeId = Guid.Parse("8A4593A5-DB68-4E60-9D7E-716EECF3DC90")

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
                    TypeId = Guid.Parse("F540F085-8856-40C0-BD20-E9A75EDA7B04"),
                    CategoryId = Guid.Parse("DAAE2DA8-A192-4D1B-9AD2-4C8CCAE60650"),
                    LocationId = Guid.Parse("452A22F0-1F19-47A7-BA17-E70862761D6B"),
                    PurposeId = Guid.Parse("8A4593A5-DB68-4E60-9D7E-716EECF3DC90")

                },
                new Vehicle()
                {
                    Make = "Fiat",
                    Model = "Talento",
                    Price = 18999,
                    FuelType = "Дизел",
                    GearBox = "Ръчна",
                    Year = "2017",
                    Doors = 2,
                    Seats = 3,
                    TankCapacity = 70,
                    HorsePower = 120,
                    Cubage = 1600,
                    ImageUrl = "https://static-eu.cargurus.com/images/forsale/2024/09/11/21/37/2018_fiat_talento-pic-8046155731279073145-1024x768.jpeg",
                    TypeId = Guid.Parse("32043B08-143B-413C-A8CB-77A9EB4BA334"),
                    CategoryId = Guid.Parse("EB337C1A-614C-4AC5-AC3A-33F7BE909C6E"),
                    LocationId = Guid.Parse("171893B6-D014-48CE-95A6-1ACB1E5CC6A9"),
                    PurposeId = Guid.Parse("A23D0FCF-4A84-4383-89A7-21340AF222BC")

                },
            };

            return vehicles;
        }
    }
}
