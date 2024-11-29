using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.Data.Models;
using CarDealership.Data.Repository.Interfaces;
using CarDealership.Services.Data.Interfaces;
using CarDealership.Web.ViewModels.Vehicle;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

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
            string? model = null, string? type = null, string? category = null, string? search = null, VehicleSorting sorting = VehicleSorting.Newest, int currPage = 1, int carsOnPage = 1)
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
                query = query.Where(v => v.TypeId.ToString().ToLower().Contains(type.ToLower()));
            }

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(v => v.CategoryId.ToString().ToLower().Contains(category.ToLower()));
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
                VehicleSorting.Newest => query.OrderBy(v => v.Year),
                _ => query.OrderByDescending(v => v.Year)
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
    }
}
