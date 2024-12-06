using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.Data.Models;
using CarDealership.Web.ViewModels.Vehicle;

namespace CarDealership.Services.Data.Interfaces
{
    public interface IVehicleService
    {
        Task<VehicleTotalModel> GetAllAsync(
            string? make = null,
            string? model = null,
            string? type = null,
            string? location = null,
            string? category = null,
            string? search = null,
            VehicleSorting sorting = VehicleSorting.Newest,
            int currPage = 1,
            int carsOnPage = 1);

        Task AddVehicleAsync(VehicleViewModel model);

        Task<VehicleViewModel> EditVehicleById(Guid id);

        Task<bool> EditVehicleAsync(VehicleViewModel model);

        Task<DeleteViewModel?> DeleteByIdAsync(Guid id);

        Task<bool> SoftDeleteAsync(Guid id);

        Task<IEnumerable<VehicleCategoryModel>> AllCategories();

        Task<IEnumerable<VehicleTypeModel>> AllTypes();

        Task<IEnumerable<string>> AllMakeNames();
        Task<IEnumerable<string>> AllModelsNames();
        Task<IEnumerable<string>> AllTypesNames();
        Task<IEnumerable<string>> AllCategoriesNames();

        Task<IEnumerable<string>> AllLocations();

        Task<VehicleSpecificationsViewModel> VehicleSpecificationsById(Guid id);
    }
}
