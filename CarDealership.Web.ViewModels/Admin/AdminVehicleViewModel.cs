using CarDealership.Web.ViewModels.Vehicle;

namespace CarDealership.Web.ViewModels.Admin
{
    public class AdminVehicleViewModel
    {
        public IEnumerable<VehicleServiceModel> AddedVehicles { get; set; }
            = new List<VehicleServiceModel>();
    }
}
