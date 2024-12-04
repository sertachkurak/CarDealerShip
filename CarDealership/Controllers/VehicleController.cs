using CarDealership.Services.Data;
using CarDealership.Services.Data.Interfaces;
using CarDealership.Web.ViewModels.Vehicle;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Web.Controllers
{
    public class VehicleController : BaseController
    {
        private readonly IVehicleService vehicleService;

        public VehicleController(IVehicleService _vehicleService)
        {
            vehicleService = _vehicleService;
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index([FromQuery] VehicleAllViewModel query)
        {


            var result = await vehicleService.GetAllAsync(query.Make, query.Model, query.Type, query.Category, query.Search, query.Sorting, query.CurrentPage, VehicleAllViewModel.VehicleOnPage);


            query.VehiclesCount = result.TotalVehicles;
            query.Makes = await vehicleService.AllMakeNames();
            query.Models = await vehicleService.AllModelsNames();
            query.Types = await vehicleService.AllTypesNames();
            query.Categories = await vehicleService.AllCategoriesNames();
            query.LocatedIns = await vehicleService.AllLocations();
            query.Vehicles = result.Vehicles;

            return View(query);


        }
        public async Task<IActionResult> Add()
        {
            
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Specifications(string? id)
        {
            Guid vehicleGuid = Guid.Empty;

            bool isGuidValid = this.IsGuidValid(id, ref vehicleGuid);

            if (!isGuidValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            var vehicle = await this.vehicleService
                .VehicleSpecificationsById(vehicleGuid);

            if (vehicle == null)
            {
                return this.RedirectToAction(nameof(Index));
            }

            return this.View(vehicle);
        }
    }
}
