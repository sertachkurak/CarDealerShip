using CarDealership.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace CarDealership.Web.ViewModels.Vehicle
{
    public class VehicleSpecificationsViewModel
    {
        public string Id { get; set; } = null!;

        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;
        public string? Year { get; set; } = null!;

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Fuel type")]
        public string FuelType { get; set; } = null!;

        public string Gearbox { get; set; } = null!;

        public int Doors { get; set; }

        public int Seats { get; set; }

        public int TankCapacity { get; set; }

        public int Horsepower { get; set; }

        public int Cubage { get; set; }

        public VehicleCategory Category { get; set; } = null!;
        public VehicleType Type { get; set; } = null!;
        public VehiclePurpose Purpose { get; set; } = null!;
        public Location Location { get; set; } = null!;
    }
}
