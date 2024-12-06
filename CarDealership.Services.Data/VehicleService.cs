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


        public VehicleService(IRepository<Vehicle, Guid> _vehicleRepository)
        {
            vehicleRepository = _vehicleRepository;
        }

        public async Task<VehicleTotalModel> GetAllAsync(string? make = null,
            string? model = null, string? type = null,string? location = null, string? category = null, string? search = null, VehicleSorting sorting = VehicleSorting.Newest, int currPage = 1, int carsOnPage = 1)
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

            Vehicle vehicle = new Vehicle()
            {
                Make = model.Make,
                Model = model.Model,
                Price = model.Price,
                FuelType = model.FuelType,
                GearBox = model.Gearbox,
                Year = model.Year,
                Doors = model.Doors,
                Seats = model.Seats,
                TankCapacity = model.TankCapacity,
                HorsePower = model.Horsepower,
                Cubage = model.Cubage,
                ImageUrl = model.ImageUrl,
                CategoryId = model.CategoryId,
                TypeId = model.TypeId
            };
            await vehicleRepository.AddAsync(vehicle);
        }

        public async Task<VehicleViewModel> EditVehicleById(Guid id)
        {
            //var car = await vehicleRepository.GetByIdAsync(id);

            VehicleViewModel? vehicle = await vehicleRepository
                .GetAllAttached()
                .Where(v => v.IsDeleted == false)
                .Select(v => new VehicleViewModel()
                {
                    Make = v.Make,
                    Model = v.Model,
                    Price = v.Price,
                    FuelType = v.FuelType,
                    Gearbox = v.GearBox,
                    Year = v.Year,
                    Doors = v.Doors,
                    Seats = v.Seats,
                    TankCapacity = v.TankCapacity,
                    Horsepower = v.HorsePower,
                    Cubage = v.Cubage,
                    ImageUrl = v.ImageUrl,
                    CategoryId = v.CategoryId,
                    TypeId = v.TypeId

                })
                .FirstOrDefaultAsync(v => v.Id == id);
            return vehicle;
        }

        public async Task<bool> EditVehicleAsync(VehicleViewModel model)
        {
            Vehicle vehicle = new Vehicle()
            {
                Make = model.Make,
                Model = model.Model,
                Price = model.Price,
                FuelType = model.FuelType,
                GearBox = model.Gearbox,
                Year = model.Year,
                Doors = model.Doors,
                Seats = model.Seats,
                TankCapacity = model.TankCapacity,
                HorsePower = model.Horsepower,
                Cubage = model.Cubage,
                ImageUrl = model.ImageUrl,
                CategoryId = model.CategoryId,
                TypeId = model.TypeId

            };

            bool result = await vehicleRepository.UpdateAsync(vehicle);

            return result;
        }

        public async Task<DeleteViewModel?> DeleteByIdAsync(Guid id)
        {
            DeleteViewModel? vehicleDelete = await vehicleRepository.GetAllAttached()
                .Where(v => v.IsDeleted == false)
                .Select(v => new DeleteViewModel()
                {
                    Id = v.Id.ToString(),
                    Make = v.Make,
                    Model = v.Model,
                    Price = v.Price,
                    FuelType = v.FuelType,
                    Gearbox = v.GearBox,
                    Year = v.Year,
                    Doors = v.Doors,
                    Seats = v.Seats,
                    TankCapacity = v.TankCapacity,
                    Horsepower = v.HorsePower,
                    Cubage = v.Cubage,
                    ImageUrl = v.ImageUrl,
                    Category = v.VehicleCategory,
                    Type = v.VehicleType
                })
                .FirstOrDefaultAsync(v => v.Id.ToLower() == id.ToString().ToLower());

            return vehicleDelete;
        }

        public async Task<bool> SoftDeleteAsync(Guid id)
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

        public async Task<IEnumerable<VehicleCategoryModel>> AllCategories()
        {
            var category = vehicleRepository.AllReadonly<VehicleCategory>()
                .OrderBy(v => v.Name)
                .Select(v => new VehicleCategoryModel()
                {
                    Id = v.Id.ToString(),
                    Name = v.Name
                })
                .ToListAsync();

            return await category;
        }

        public async Task<IEnumerable<VehicleTypeModel>> AllTypes()
        {
            var type = vehicleRepository.AllReadonly<VehicleType>()
                .OrderBy(v => v.Name)
                .Select(v => new VehicleTypeModel()
                {
                    Id = v.Id.ToString(),
                    Model = v.Name
                })
                .ToListAsync();

            return await type;
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

        public async Task<IEnumerable<string>> AllLocations()
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
