using System.ComponentModel.DataAnnotations;

namespace CarDealership.Data.Models
{
    using static Common.Constants.VehicleTypeValidations;

    public class VehicleType
    {

        public Guid Id { get; set; } = Guid.NewGuid();


        [Required] 
        [MaxLength(NameMaxLength)] 
        public string Name { get; set; } = null!;

        public List<Vehicle> Vehicles { get; set; }
            = new List<Vehicle>();
    }
}
