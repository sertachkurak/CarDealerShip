using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealership.Data.Models
{
    using static Common.Constants.VehicleValidations;
    public class Vehicle
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required] 
        [MaxLength(MakeMaxLength)] 
        public string Make { get; set; } = null!;

        [Required] 
        [MaxLength(ModelMaxLength)] 
        public string Model { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(FuelTypeMaxLength)]
        public string FuelType { get; set; } = null!;

        [Required]
        [MaxLength(GearBoxMaxLength)]
        public string GearBox { get; set; } = null!;

        [Required]
        public string Year { get; set; } = null!;

        [Required]
        [MaxLength(DoorsMaxCount)]
        public int Doors { get; set; }

        [Required]
        [MaxLength(SeatsMaxCount)]
        public int Seats { get; set; }

        [Required]
        [MaxLength(TankMaxCapacity)]
        public int TankCapacity { get; set; }

        [Required]
        [MaxLength(HorsepowerMaxLength)]
        public int HorsePower { get; set; }

        [Required]
        [MaxLength(MaxCubage)]
        public int Cubage { get; set; }

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public VehicleType VehicleType { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public VehicleCategory VehicleCategory { get; set; } = null!;

        [Required]
        public int LocationId { get; set; }

        [ForeignKey(nameof(LocationId))]
        public Location Location { get; set; } = null!;

        [Required]
        public int PurposeId { get; set; }

        [ForeignKey(nameof(PurposeId))]
        public VehiclePurpose Purpose { get; set; } = null!;

        public bool IsAvailable { get; set; } = true;
    }
}
