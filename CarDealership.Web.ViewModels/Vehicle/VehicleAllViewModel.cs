namespace CarDealership.Web.ViewModels.Vehicle
{
    public class VehicleAllViewModel
    {

        public const int VehicleOnPage = 6;

        public string? Make { get; set; }

        public string? Model { get; set; }
        public string? LocatedIn { get; set; }

        public string? Category { get; set; }

        public string? Type { get; set; }

        public string? Search { get; set; }

        public VehicleSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int VehiclesCount { get; set; }

        public IEnumerable<string> LocatedIns { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> Makes { get; set; } = Enumerable.Empty<string>();
        public IEnumerable<string> Models { get; set; } = Enumerable.Empty<string>();
        public IEnumerable<string> Categories { get; set; } = Enumerable.Empty<string>();
        public IEnumerable<string> Types { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<VehicleServiceModel> Vehicles { get; set; } = Enumerable.Empty<VehicleServiceModel>();


    }
}
