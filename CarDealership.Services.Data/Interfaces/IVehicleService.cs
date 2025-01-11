using CarDealership.Web.ViewModels.Vehicle;

namespace CarDealership.Services.Data.Interfaces
{
    public interface IVehicleService
    {
        Task<VehicleTotalModel> Index(
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
        Task<bool> CaregoryExist(Guid categoryGuid);

        Task<VehicleViewModel> EditVehicleById(Guid id, bool isAdmin);

        Task<bool> EditVehicleAsync(Guid id, VehicleViewModel model, bool isAdmin);

        Task<DeleteViewModel?> DeleteByIdAsync(Guid id, bool isAdmin);

        Task<bool> SoftDeleteAsync(Guid id, bool isAdmin);

        Task<IEnumerable<VehicleServiceModel>> AllVehiclesByAgentId(Guid id);

        Task<IEnumerable<VehicleCategoryModel>> AllCategories();
        Task<IEnumerable<VehicleLocationModel>> AllLocations();
        Task<IEnumerable<VehiclePurposeModel>> AllPurposes();

        Task<IEnumerable<VehicleTypeModel>> AllTypes();

        Task<IEnumerable<string>> AllMakeNames();
        Task<IEnumerable<string>> AllModelsNames();
        Task<IEnumerable<string>> AllTypesNames();
        Task<IEnumerable<string>> AllCategoriesNames();

        Task<IEnumerable<string>> AllLocationsNames();

        Task<VehicleSpecificationsViewModel> VehicleSpecificationsById(Guid id);
    }
}
