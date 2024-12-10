using CarDealership.Data.Models;
using CarDealership.Data.Repository.Interfaces;
using CarDealership.Services.Data.Interfaces;
using CarDealership.Web.ViewModels.Vehicle;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Services.Data
{
    public class VehicleService : BaseService, IVehicleService
    {
        private readonly IRepository<Vehicle, Guid> vehicleRepository;


        public VehicleService(IRepository<Vehicle, Guid> vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository;
        }

        public async Task<VehicleTotalModel> GetAllAsync(string? make = null,
            string? model = null, string? type = null, string? location = null, string? category = null, string? search = null, VehicleSorting sorting = VehicleSorting.Newest, int currPage = 1, int carsOnPage = 1)
        {
            var query = vehicleRepository.GetAllAttached();

            var result = new VehicleTotalModel();

            if (!string.IsNullOrEmpty(make))
            {
                query = query.Where(v => v.Make.ToLower().Contains(make.ToLower()));
            }

            if (!string.IsNullOrEmpty(model))
            {
                query = query.Where(v => v.Model.ToLower().Contains(model.ToLower()));
            }

            if (!string.IsNullOrEmpty(type))
            {
                query = query.Where(v => v.VehicleType.Name.ToString().ToLower().Contains(type.ToLower()));
            }

            if (!string.IsNullOrEmpty(location))
            {
                query = query.Where(v => v.Location.Name.ToString().ToLower().Contains(location.ToLower()));
            }

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(v => v.VehicleCategory.Name.ToString().ToLower().Contains(category.ToLower()));
            }

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(v =>
                    v.Make.ToLower().Contains(search.ToLower()) ||
                    v.Model.ToLower().Contains(search.ToLower()));
            }

            query = sorting switch
            {
                VehicleSorting.TheCheapOnesFirst => query.OrderBy(v => v.Price),
                VehicleSorting.FirstDearOnes => query.OrderByDescending(v => v.Price),
                VehicleSorting.Newest => query.OrderByDescending(v => v.Year),
                _ => query.OrderBy(v => v.Year)
            };


            var skip = (currPage - 1) * carsOnPage;

            query = query.Skip(skip).Take(carsOnPage);


            result.Vehicles = await query
                .Select(v => new VehicleServiceModel()
                {
                    Id = v.Id.ToString(),
                    Make = v.Make,
                    Model = v.Model,
                    Price = v.Price,
                    ImageUrl = v.ImageUrl
                })
                .ToListAsync();

            return result;
        }

        public async Task AddVehicleAsync(VehicleViewModel model)
        {

            var vehicle = new Vehicle()
            {
                Id = Guid.NewGuid(),
                Make = model.Make,
                Model = model.Model,
                Price = model.Price,
                FuelType = model.FuelType,
                GearBox = model.GearBox,
                Year = model.Year,
                Doors = model.Doors,
                Seats = model.Seats,
                TankCapacity = model.TankCapacity,
                HorsePower = model.HorsePower,
                Cubage = model.Cubage,
                ImageUrl = model.ImageUrl,
                CategoryId = model.CategoryId,
                TypeId = model.TypeId,
                LocationId = model.LocationId,
                PurposeId = model.PurposeId
            };
            await vehicleRepository.AddAsync(vehicle);
        }

        public async Task<bool> CaregoryExist(Guid categoryGuid)
        {
            return await vehicleRepository.AllReadonly<VehicleCategory>()
                 .AnyAsync(v => v.Id == categoryGuid);
        }

        public async Task<VehicleViewModel> EditVehicleById(Guid id, bool isAdmin)
        {
            var vehicle = await vehicleRepository
                .GetAllAttached()
                .Where(v => v.IsDeleted == false && v.Id == id)
                .Select(v => new VehicleViewModel
                {
                    Id = v.Id,
                    Make = v.Make,
                    Model = v.Model,
                    Price = v.Price,
                    FuelType = v.FuelType,
                    GearBox = v.GearBox,
                    Year = v.Year,
                    Doors = v.Doors,
                    Seats = v.Seats,
                    TankCapacity = v.TankCapacity,
                    HorsePower = v.HorsePower,
                    Cubage = v.Cubage,
                    ImageUrl = v.ImageUrl,
                    CategoryId = v.CategoryId,
                    TypeId = v.TypeId,
                    LocationId = v.LocationId,
                    PurposeId = v.PurposeId
                })
                .FirstOrDefaultAsync();

            return vehicle;
        }

        public async Task<bool> EditVehicleAsync(Guid id, VehicleViewModel model, bool isAdmin)
        {
            var vehicle = await vehicleRepository.GetByIdAsync(id);

            vehicle.Make = model.Make;
            vehicle.Model = model.Model;
            vehicle.FuelType = model.FuelType;
            vehicle.GearBox = model.GearBox;
            vehicle.Year = model.Year;
            vehicle.Seats = model.Seats;
            vehicle.Doors = model.Doors;
            vehicle.TankCapacity = model.TankCapacity;
            vehicle.HorsePower = model.HorsePower;
            vehicle.Cubage = model.Cubage;
            vehicle.ImageUrl = model.ImageUrl;
            vehicle.CategoryId = model.CategoryId;
            vehicle.TypeId = model.TypeId;
            vehicle.LocationId = model.LocationId;
            vehicle.PurposeId = model.PurposeId;

            bool result = await vehicleRepository.UpdateAsync(vehicle);

            return result;
        }

        public async Task<DeleteViewModel?> DeleteByIdAsync(Guid id, bool isAdmin)
        {
            DeleteViewModel? vehicleDelete = await vehicleRepository.GetAllAttached()
                .Where(v => v.IsDeleted == false && v.Id == id)
                .Select(v => new DeleteViewModel()
                {
                    Id = v.Id,
                    Make = v.Make,
                    Model = v.Model,
                    Year = v.Year,
                    ImageUrl = v.ImageUrl,
                })
                .FirstOrDefaultAsync();

            return vehicleDelete;
        }

        public async Task<bool> SoftDeleteAsync(Guid id, bool isAdmin)
        {
            Vehicle? deleteVehicle = await vehicleRepository
                .FirstOrDefaultAsync(c => c.Id.ToString().ToLower() == id.ToString().ToLower());
            if (deleteVehicle == null)
            {
                return false;
            }

            deleteVehicle.IsDeleted = true;
            return await this.vehicleRepository.UpdateAsync(deleteVehicle);
        }

        public async Task<IEnumerable<VehicleServiceModel>> AllVehiclesByAgentId(Guid id)
        {
            return await vehicleRepository.AllReadonly<Vehicle>()
                .Where(c => c.IsDeleted)
                .Select(c => new VehicleServiceModel()
                {
                    Id = c.Id.ToString(),
                    Make = c.Make,
                    Model = c.Model,
                    ImageUrl = c.ImageUrl,
                    Price = c.Price,
                })
                .ToListAsync();
        }
        public async Task<IEnumerable<VehicleCategoryModel>> AllCategories()
        {
            return await vehicleRepository.AllReadonly<VehicleCategory>()
                .OrderBy(v => v.Name)
                .Select(v => new VehicleCategoryModel()
                {
                    Id = v.Id,
                    Name = v.Name
                })
                .ToListAsync();

        }

        public async Task<IEnumerable<VehicleLocationModel>> AllLocations()
        {
            return await vehicleRepository.AllReadonly<Location>()
                .OrderBy(v => v.Name)
                .Select(v => new VehicleLocationModel()
                {
                    Id = v.Id,
                    Name = v.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<VehiclePurposeModel>> AllPurposes()
        {
            return await vehicleRepository.AllReadonly<VehiclePurpose>()
                .OrderBy(v => v.Name)
                .Select(v => new VehiclePurposeModel()
                {
                    Id = v.Id,
                    Name = v.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<VehicleTypeModel>> AllTypes()
        {
            return await vehicleRepository.AllReadonly<VehicleType>()
                .OrderBy(v => v.Name)
                .Select(v => new VehicleTypeModel()
                {
                    Id = v.Id,
                    Name = v.Name
                })
                .ToListAsync();

        }

        public async Task<IEnumerable<string>> AllMakeNames()
        {
            return await vehicleRepository.AllReadonly<Vehicle>()
                .Select(v => v.Make)
                .Distinct()
                .ToListAsync();

        }
        public async Task<IEnumerable<string>> AllModelsNames()
        {
            return await vehicleRepository.AllReadonly<Vehicle>()
                .Select(v => v.Model)
                .Distinct()
                .ToListAsync();

        }
        public async Task<IEnumerable<string>> AllTypesNames()
        {
            return await vehicleRepository.AllReadonly<VehicleType>()
                .Select(v => v.Name)
                .Distinct()
                .ToListAsync();

        }
        public async Task<IEnumerable<string>> AllCategoriesNames()
        {
            return await vehicleRepository.AllReadonly<VehicleCategory>()
                .Select(v => v.Name)
                .Distinct()
                .ToListAsync();

        }

        public async Task<IEnumerable<string>> AllLocationsNames()
        {
            return await vehicleRepository.AllReadonly<Location>()
                .Select(v => v.Name)
                .Distinct()
                .ToListAsync();
        }



        public async Task<VehicleSpecificationsViewModel> VehicleSpecificationsById(Guid id)
        {
            var vehicle = vehicleRepository.GetAllAttached()
                .Where(v => v.Id == id)
                .Where(v => v.IsDeleted == false)
                .Select(v => new VehicleSpecificationsViewModel()
                {
                    Id = v.Id.ToString(),
                    Make = v.Make,
                    Model = v.Model,
                    ImageUrl = v.ImageUrl,
                    FuelType = v.FuelType,
                    Gearbox = v.GearBox,
                    Year = v.Year,
                    Doors = v.Doors,
                    Seats = v.Seats,
                    Price = v.Price,
                    TankCapacity = v.TankCapacity,
                    Horsepower = v.HorsePower,
                    Cubage = v.Cubage,
                    Category = v.VehicleCategory,
                    Type = v.VehicleType,
                    Purpose = v.Purpose,
                    Location = v.Location,
                }).FirstOrDefaultAsync();

            return await vehicle;
        }
    }
}
