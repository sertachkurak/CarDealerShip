namespace CarDealership.Web.ViewModels.Vehicle
{
    public class VehicleTotalModel
    {
        public int TotalVehicles { get; set; }

        public IEnumerable<VehicleServiceModel> Vehicles { get; set; } = new List<VehicleServiceModel>();
    }
}
