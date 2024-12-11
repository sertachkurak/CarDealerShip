using System.ComponentModel.DataAnnotations;

namespace CarDealership.Web.ViewModels.Vehicle
{
    public class DeleteViewModel
    {
        public Guid Id { get; set; }

        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;
        public string? Year { get; set; } = null!;

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

    }
}
