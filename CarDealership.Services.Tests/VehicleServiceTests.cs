using System.Linq.Expressions;
using CarDealership.Data.Models;
using CarDealership.Data.Repository.Interfaces;
using CarDealership.Services.Data;
using CarDealership.Web.ViewModels.Vehicle;
using MockQueryable;


namespace CarDealership.Services.Tests
{

    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [TestFixture]
    public class VehicleServiceTests
    {
        private Mock<IRepository<Vehicle, Guid>> _vehicleRepositoryMock;
        private VehicleService _vehicleService;

        [SetUp]
        public void SetUp()
        {
            _vehicleRepositoryMock = new Mock<IRepository<Vehicle, Guid>>();
            _vehicleService = new VehicleService(_vehicleRepositoryMock.Object);
        }

        [Test]
        public async Task GetAllAsync_FiltersAndSortsCorrectly()
        {
            var vehicles = new List<Vehicle>
        {
            new Vehicle { Id =Guid.NewGuid(), Make = "Toyota", Model = "Corolla", Price = 15000, Year = "2020", ImageUrl = "url1", VehicleType = new VehicleType { Name = "Sedan" }, Location = new Location { Name = "NY" }, VehicleCategory = new VehicleCategory { Name = "Compact" } },
            new Vehicle { Id = Guid.NewGuid(), Make = "Honda", Model = "Civic", Price = 20000, Year = "2022", ImageUrl = "url2", VehicleType = new VehicleType { Name = "Sedan" }, Location = new Location { Name = "LA" }, VehicleCategory = new VehicleCategory { Name = "Compact" } }
        }.AsQueryable().BuildMock();

            _vehicleRepositoryMock.Setup(r => r.GetAllAttached()).Returns(vehicles);

            var result = await _vehicleService.GetAllAsync(make: "Toyota", model: "Corolla", type: "Sedan", location: "NY", category: "Compact", search: "Toyota", sorting: VehicleSorting.Newest, currPage: 1, carsOnPage: 1);

            Assert.AreEqual(1, result.Vehicles.Count());
            Assert.AreEqual("Toyota", result.Vehicles.First().Make);
            Assert.AreEqual("Corolla", result.Vehicles.First().Model);
        }

        [Test]
        public async Task GetAllAsync_PaginationWorksCorrectly()
        {
            var vehicles = new List<Vehicle>
        {
            new Vehicle { Id = Guid.NewGuid(), Make = "Toyota", Model = "Corolla", Price = 15000, Year = "2020", ImageUrl = "url1" },
            new Vehicle { Id = Guid.NewGuid(), Make = "Honda", Model = "Civic", Price = 20000, Year = "2022", ImageUrl = "url2" }
        }.AsQueryable().BuildMock();

            _vehicleRepositoryMock.Setup(r => r.GetAllAttached()).Returns(vehicles);

            var result = await _vehicleService.GetAllAsync(currPage: 2, carsOnPage: 1);

            Assert.AreEqual(1, result.Vehicles.Count());
            Assert.AreEqual("Toyota", result.Vehicles.First().Make);
        }

        [Test]
        public async Task GetAllAsync_SortingByPriceWorksCorrectly()
        {
            var vehicles = new List<Vehicle>
        {
            new Vehicle { Id = Guid.NewGuid(), Make = "Toyota", Model = "Corolla", Price = 15000, Year = "2020", ImageUrl = "url1" },
            new Vehicle { Id = Guid.NewGuid(), Make = "Honda", Model = "Civic", Price = 20000, Year = "2022", ImageUrl = "url2" }
        }.AsQueryable().BuildMock();

            _vehicleRepositoryMock.Setup(r => r.GetAllAttached()).Returns(vehicles);

            var result = await _vehicleService.GetAllAsync(sorting: VehicleSorting.TheCheapOnesFirst);

            Assert.AreEqual("Toyota", result.Vehicles.First().Make);
        }
        [Test]
        public async Task AddVehicleAsync_AddsVehicleToRepository()
        {
            var model = new VehicleViewModel
            {
                Make = "Toyota",
                Model = "Corolla",
                Price = 15000,
                FuelType = "Gasoline",
                GearBox = "Automatic",
                Year = "2020",
                Doors = 4,
                Seats = 5,
                TankCapacity = 50,
                HorsePower = 130,
                Cubage = 1800,
                ImageUrl = "url1",
                CategoryId = Guid.NewGuid(),
                TypeId = Guid.NewGuid(),
                LocationId = Guid.NewGuid(),
                PurposeId = Guid.NewGuid()
            };

            Vehicle capturedVehicle = null;
            _vehicleRepositoryMock.Setup(r => r.AddAsync(It.IsAny<Vehicle>())).Callback<Vehicle>(v => capturedVehicle = v);

            await _vehicleService.AddVehicleAsync(model);

            Assert.NotNull(capturedVehicle);
            Assert.AreEqual(model.Make, capturedVehicle.Make);
            Assert.AreEqual(model.Model, capturedVehicle.Model);
            Assert.AreEqual(model.Price, capturedVehicle.Price);
            Assert.AreEqual(model.FuelType, capturedVehicle.FuelType);
            Assert.AreEqual(model.GearBox, capturedVehicle.GearBox);
            Assert.AreEqual(model.Year, capturedVehicle.Year);
            Assert.AreEqual(model.Doors, capturedVehicle.Doors);
            Assert.AreEqual(model.Seats, capturedVehicle.Seats);
            Assert.AreEqual(model.TankCapacity, capturedVehicle.TankCapacity);
            Assert.AreEqual(model.HorsePower, capturedVehicle.HorsePower);
            Assert.AreEqual(model.Cubage, capturedVehicle.Cubage);
            Assert.AreEqual(model.ImageUrl, capturedVehicle.ImageUrl);
            Assert.AreEqual(model.CategoryId, capturedVehicle.CategoryId);
            Assert.AreEqual(model.TypeId, capturedVehicle.TypeId);
            Assert.AreEqual(model.LocationId, capturedVehicle.LocationId);
            Assert.AreEqual(model.PurposeId, capturedVehicle.PurposeId);
        }
        [Test]
        public async Task CategoryExist_ReturnsTrue_WhenCategoryExists()
        {
            var categoryGuid = Guid.NewGuid();
            var vehicles = new List<VehicleCategory>
        {
            new VehicleCategory { Id = categoryGuid }
        }.AsQueryable();

            _vehicleRepositoryMock.Setup(r => r.AllReadonly<VehicleCategory>())
                .Returns(vehicles.BuildMock());

            var result = await _vehicleService.CaregoryExist(categoryGuid);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task CategoryExist_ReturnsFalse_WhenCategoryDoesNotExist()
        {
            var categoryGuid = Guid.NewGuid();
            var vehicles = new List<VehicleCategory>().AsQueryable();

            _vehicleRepositoryMock.Setup(r => r.AllReadonly<VehicleCategory>())
                .Returns(vehicles.BuildMock());

            var result = await _vehicleService.CaregoryExist(categoryGuid);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task EditVehicleById_ReturnsCorrectVehicle()
        {
            var vehicleId = Guid.NewGuid();
            var vehicles = new List<Vehicle>
        {
            new Vehicle { Id = vehicleId, Make = "Toyota", Model = "Corolla", IsDeleted = false }
        }.AsQueryable();

            _vehicleRepositoryMock.Setup(r => r.GetAllAttached())
                .Returns(vehicles.BuildMock());

            var result = await _vehicleService.EditVehicleById(vehicleId, false);

            Assert.IsNotNull(result);
            Assert.AreEqual("Toyota", result.Make);
            Assert.AreEqual("Corolla", result.Model);
        }

        [Test]
        public async Task EditVehicleAsync_ReturnsTrue_WhenVehicleUpdated()
        {
            var vehicleId = Guid.NewGuid();
            var model = new VehicleViewModel
            {
                Make = "Honda",
                Model = "Civic",
                FuelType = "Petrol",
                GearBox = "Manual",
                Year = "2022",
                Seats = 5,
                Doors = 4,
                TankCapacity = 50,
                HorsePower = 150,
                Cubage = 1800,
                ImageUrl = "url_to_image",
                CategoryId = Guid.NewGuid(),
                TypeId = Guid.NewGuid(),
                LocationId = Guid.NewGuid(),
                PurposeId = Guid.NewGuid()
            };

            var vehicle = new Vehicle { Id = vehicleId, Make = "Toyota", Model = "Corolla" };

            _vehicleRepositoryMock.Setup(r => r.GetByIdAsync(vehicleId)).ReturnsAsync(vehicle);
            _vehicleRepositoryMock.Setup(r => r.UpdateAsync(It.IsAny<Vehicle>())).ReturnsAsync(true);

            var result = await _vehicleService.EditVehicleAsync(vehicleId, model, false);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task EditVehicleAsync_ReturnsFalse_WhenUpdateFails()
        {
            var vehicleId = Guid.NewGuid();
            var model = new VehicleViewModel
            {
                Make = "Honda",
                Model = "Civic",
                FuelType = "Petrol",
                GearBox = "Manual",
                Year = "2022",
                Seats = 5,
                Doors = 4,
                TankCapacity = 50,
                HorsePower = 150,
                Cubage = 1800,
                ImageUrl = "url_to_image",
                CategoryId = Guid.NewGuid(),
                TypeId = Guid.NewGuid(),
                LocationId = Guid.NewGuid(),
                PurposeId = Guid.NewGuid()
            };

            var vehicle = new Vehicle { Id = vehicleId, Make = "Toyota", Model = "Corolla" };

            _vehicleRepositoryMock.Setup(r => r.GetByIdAsync(vehicleId)).ReturnsAsync(vehicle);
            _vehicleRepositoryMock.Setup(r => r.UpdateAsync(It.IsAny<Vehicle>())).ReturnsAsync(false);

            var result = await _vehicleService.EditVehicleAsync(vehicleId, model, false);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task DeleteByIdAsync_ReturnsCorrectDeleteViewModel_WhenVehicleExists()
        {
            var vehicleId = Guid.NewGuid();
            var vehicles = new List<Vehicle>
        {
            new Vehicle { Id = vehicleId, Make = "Toyota", Model = "Corolla", IsDeleted = false }
        }.AsQueryable();

            _vehicleRepositoryMock.Setup(r => r.GetAllAttached())
                .Returns(vehicles.BuildMock());

            var result = await _vehicleService.DeleteByIdAsync(vehicleId, false);

            Assert.IsNotNull(result);
            Assert.AreEqual("Toyota", result?.Make);
            Assert.AreEqual("Corolla", result?.Model);
        }

        [Test]
        public async Task DeleteByIdAsync_ReturnsNull_WhenVehicleDoesNotExist()
        {
            var vehicleId = Guid.NewGuid();
            var vehicles = new List<Vehicle>().AsQueryable();

            _vehicleRepositoryMock.Setup(r => r.GetAllAttached())
                .Returns(vehicles.BuildMock());

            var result = await _vehicleService.DeleteByIdAsync(vehicleId, false);

            Assert.IsNull(result);
        }
        [Test]
        public async Task SoftDeleteAsync_ReturnsTrue_WhenVehicleExists()
        {
            var vehicleId = Guid.NewGuid();
            var vehicle = new Vehicle { Id = vehicleId, IsDeleted = false };

            _vehicleRepositoryMock.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<Vehicle, bool>>>()))
                .ReturnsAsync(vehicle);
            _vehicleRepositoryMock.Setup(r => r.UpdateAsync(It.IsAny<Vehicle>())).ReturnsAsync(true);

            var result = await _vehicleService.SoftDeleteAsync(vehicleId, true);

            Assert.IsTrue(result);
            Assert.IsTrue(vehicle.IsDeleted);
        }

        [Test]
        public async Task SoftDeleteAsync_ReturnsFalse_WhenVehicleDoesNotExist()
        {
            var vehicleId = Guid.NewGuid();
            _vehicleRepositoryMock.Setup(r => r.FirstOrDefaultAsync(It.IsAny<Expression<Func<Vehicle, bool>>>()))
                .ReturnsAsync((Vehicle)null);

            var result = await _vehicleService.SoftDeleteAsync(vehicleId, true);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task AllVehiclesByAgentId_ReturnsVehicles_WhenVehiclesExist()
        {
            var agentId = Guid.NewGuid();
            var vehicles = new List<Vehicle>
        {
            new Vehicle { Id = Guid.NewGuid(), Make = "Toyota", Model = "Corolla", IsDeleted = false }
        }.AsQueryable();

            _vehicleRepositoryMock.Setup(r => r.AllReadonly<Vehicle>())
                .Returns(vehicles.BuildMock());

            var result = await _vehicleService.AllVehiclesByAgentId(agentId);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());
        }

        [Test]
        public async Task AllVehiclesByAgentId_ReturnsEmpty_WhenNoVehiclesExist()
        {
            var agentId = Guid.NewGuid();
            var vehicles = new List<Vehicle>().AsQueryable();

            _vehicleRepositoryMock.Setup(r => r.AllReadonly<Vehicle>())
                .Returns(vehicles.BuildMock());

            var result = await _vehicleService.AllVehiclesByAgentId(agentId);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());
        }

        [Test]
        public async Task AllCategories_ReturnsCategories_WhenCategoriesExist()
        {
            var categories = new List<VehicleCategory>
        {
            new VehicleCategory { Id = Guid.NewGuid(), Name = "SUV" }
        }.AsQueryable();

            _vehicleRepositoryMock.Setup(r => r.AllReadonly<VehicleCategory>())
                .Returns(categories.BuildMock());

            var result = await _vehicleService.AllCategories();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }

        [Test]
        public async Task AllLocations_ReturnsLocations_WhenLocationsExist()
        {
            var locations = new List<Location>
        {
            new Location { Id = Guid.NewGuid(), Name = "New York" }
        }.AsQueryable();

            _vehicleRepositoryMock.Setup(r => r.AllReadonly<Location>())
                .Returns(locations.BuildMock());

            var result = await _vehicleService.AllLocations();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }

        [Test]
        public async Task AllPurposes_ReturnsPurposes_WhenPurposesExist()
        {
            var purposes = new List<VehiclePurpose>
        {
            new VehiclePurpose { Id = Guid.NewGuid(), Name = "Commercial" }
        }.AsQueryable();

            _vehicleRepositoryMock.Setup(r => r.AllReadonly<VehiclePurpose>())
                .Returns(purposes.BuildMock());

            var result = await _vehicleService.AllPurposes();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }

        [Test]
        public async Task AllTypes_ReturnsTypes_WhenTypesExist()
        {
            var types = new List<VehicleType>
        {
            new VehicleType { Id = Guid.NewGuid(), Name = "Sedan" }
        }.AsQueryable();

            _vehicleRepositoryMock.Setup(r => r.AllReadonly<VehicleType>())
                .Returns(types.BuildMock());

            var result = await _vehicleService.AllTypes();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }

        [Test]
        public async Task AllMakeNames_ReturnsMakes_WhenMakesExist()
        {
            var vehicles = new List<Vehicle>
        {
            new Vehicle { Make = "Toyota" },
            new Vehicle { Make = "Honda" }
        }.AsQueryable();

            _vehicleRepositoryMock.Setup(r => r.AllReadonly<Vehicle>())
                .Returns(vehicles.BuildMock());

            var result = await _vehicleService.AllMakeNames();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }

        [Test]
        public async Task VehicleSpecificationsById_ReturnsVehicle_WhenVehicleExists()
        {
            var vehicleId = Guid.NewGuid();
            var vehicle = new Vehicle
            {
                Id = vehicleId,
                Make = "Toyota",
                Model = "Corolla",
                FuelType = "Petrol",
                GearBox = "Manual",
                Year = "2022",
                Seats = 5,
                Doors = 4,
                Price = 20000
            };

            _vehicleRepositoryMock.Setup(r => r.GetAllAttached())
                .Returns(new List<Vehicle> { vehicle }.AsQueryable().BuildMock());

            var result = await _vehicleService.VehicleSpecificationsById(vehicleId);

            Assert.IsNotNull(result);
            Assert.AreEqual("Toyota", result.Make);
            Assert.AreEqual("Corolla", result.Model);
        }

        [Test]
        public async Task VehicleSpecificationsById_ReturnsNull_WhenVehicleDoesNotExist()
        {
            var vehicleId = Guid.NewGuid();
            _vehicleRepositoryMock.Setup(r => r.GetAllAttached())
                .Returns(new List<Vehicle>().AsQueryable().BuildMock());

            var result = await _vehicleService.VehicleSpecificationsById(vehicleId);

            Assert.IsNull(result);
        }
    }
}

