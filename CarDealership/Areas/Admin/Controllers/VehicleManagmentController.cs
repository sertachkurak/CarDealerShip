using CarDealership.Services.Data.Interfaces;
using CarDealership.Web.Controllers;
using CarDealership.Web.ViewModels.Vehicle;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Web.Areas.Admin.Controllers
{
    using static Common.Constants.AdminConstants;

    [Area(AdminRoleName)]
    [Authorize(Roles = AdminRoleName)]
    public class VehicleManagmentController : BaseController
    {
        private readonly IVehicleService vehicleService;

        public VehicleManagmentController(IVehicleService vehicleService, IManagerService managerService)
            : base(managerService)
        {
            this.vehicleService = vehicleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] VehicleAllViewModel query)
        {


            var result = await vehicleService.GetAllAsync(query.Make, query.Model, query.Type,
                query.LocatedIn, query.Category, query.Search, query.Sorting, query.CurrentPage, VehicleAllViewModel.VehicleOnPage);


            query.VehiclesCount = result.TotalVehicles;
            query.Makes = await vehicleService.AllMakeNames();
            query.Models = await vehicleService.AllModelsNames();
            query.Types = await vehicleService.AllTypesNames();
            query.Categories = await vehicleService.AllCategoriesNames();
            query.LocatedIns = await vehicleService.AllLocationsNames();
            query.Vehicles = result.Vehicles;

            return View(query);

        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Add()
        {

            var vehicle = new VehicleViewModel
            {
                VehicleCategories = await vehicleService.AllCategories(),
                VehicleTypes = await vehicleService.AllTypes(),
                VehicleLocations = await vehicleService.AllLocations(),
                VehiclePurposes = await vehicleService.AllPurposes()
            };

            return View(vehicle);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(VehicleViewModel vehicleViewModel)
        {
            if (await vehicleService.CaregoryExist(vehicleViewModel.CategoryId) == false)
            {
                ModelState.AddModelError(nameof(vehicleViewModel.CategoryId), "Category does not exists");
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(vehicleViewModel);
            }

            vehicleViewModel.VehicleCategories = await vehicleService.AllCategories();
            vehicleViewModel.VehicleTypes = await vehicleService.AllTypes();
            vehicleViewModel.VehicleLocations = await vehicleService.AllLocations();
            vehicleViewModel.VehiclePurposes = await vehicleService.AllPurposes();

            await this.vehicleService.AddVehicleAsync(vehicleViewModel);

            return this.RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(Guid id)
        {

            Guid vehicleGuid = Guid.Empty;
            bool isIdValid = this.IsGuidValid(id.ToString(), ref vehicleGuid);
            if (!isIdValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            bool isAdmin = User.IsInRole(AdminRoleName);

            var vehicle = await vehicleService.EditVehicleById(id, isAdmin);

            vehicle.VehicleCategories = await vehicleService.AllCategories();
            vehicle.VehicleTypes = await vehicleService.AllTypes();
            vehicle.VehicleLocations = await vehicleService.AllLocations();
            vehicle.VehiclePurposes = await vehicleService.AllPurposes();

            return View(vehicle);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(Guid id, VehicleViewModel editModel)
        {

            if (!ModelState.IsValid)
            {
                return View(editModel);
            }

            bool isAdmin = User.IsInRole(AdminRoleName);

            await vehicleService.EditVehicleAsync(editModel.Id, editModel, isAdmin);


            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            bool isAdmin = User.IsInRole(AdminRoleName);

            var deleteModel = await vehicleService.DeleteByIdAsync(id, isAdmin);

            if (deleteModel == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return this.View(deleteModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id, DeleteViewModel deleteVehicle)
        {
            bool isAdmin = User.IsInRole(AdminRoleName);

            bool isDeleted = await vehicleService
                .SoftDeleteAsync(id, isAdmin);

            if (!isDeleted)
            {
                return RedirectToAction(nameof(Delete), new { id = deleteVehicle.Id });
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
