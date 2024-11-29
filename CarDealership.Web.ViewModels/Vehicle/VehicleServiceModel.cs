using System.ComponentModel.DataAnnotations;

namespace CarDealership.Web.ViewModels.Vehicle
{
    public class VehicleServiceModel
    {
        public string Id { get; set; } = null!;

        public string Make { get; set; } = null!;
        public string? Year { get; set; } = null!;

        public string Model { get; set; } = null!;

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Display(Name = "Price")]
        public decimal Price { get; set; }
    }
}
