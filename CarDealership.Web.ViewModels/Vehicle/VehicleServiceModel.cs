using System.ComponentModel.DataAnnotations;

namespace CarDealership.Web.ViewModels.Vehicle
{
    public class VehicleServiceModel
    {
        public Guid Id { get; set; }

        public string Make { get; set; } = null!;
        public string? Year { get; set; } = null!;

        public string Model { get; set; } = null!;

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Display(Name = "Price")]
        public decimal Price { get; set; }
        public Guid UserId { get; set; }
    }
}
