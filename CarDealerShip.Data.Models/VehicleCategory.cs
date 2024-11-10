using System.ComponentModel.DataAnnotations;

namespace CarDealership.Data.Models
{
    using static Common.Constants.VehicleCategoryValidations;
    public class VehicleCategory
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)] 
        public string Name { get; set; } = null!;

        public List<Vehicle> Vehicles { get; set; }
            = new List<Vehicle>();
    }
}
