using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Web.ViewModels.Vehicle
{
    using static Common.Constants.VehicleValidations;

    public class VehicleViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [MinLength(MakeMinLength)]
        [MaxLength(MakeMaxLength)]
        public string Make { get; set; } = null!;

        [Required]
        [MinLength(ModelMinLength)]
        [MaxLength(ModelMaxLength)]
        public string Model { get; set; } = null!;

        [Required]
        [Display(Name = "Цена")]
        [Range(1000.00, 510000.00, ErrorMessage = "")]
        public decimal Price { get; set; }

        [Required]
        [MinLength(FuelTypeMinLength)]
        [MaxLength(FuelTypeMaxLength)]
        public string FuelType { get; set; } = null!;

        [Required]
        [MinLength(GearBoxMinLength)]
        [MaxLength(GearBoxMaxLength)]
        public string Gearbox { get; set; } = null!;

        [Required]
        public string Year { get; set; } = null!;

        [Required]
        [Range(DoorsMinCount, DoorsMaxCount)]
        public int Doors { get; set; }

        [Required]
        [Range(SeatsMinCount, SeatsMaxCount)]
        public int Seats { get; set; }

        [Required]
        [Range(TankMinCapacity, TankMaxCapacity)]
        public int TankCapacity { get; set; }

        [Required]
        [Range(HorsepowerMinLength, HorsepowerMaxLength)]
        public int Horsepower { get; set; }

        [Required]
        [Range(MinCubage, MaxCubage)]
        public int Cubage { get; set; }

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<VehicleCategoryModel> VehicleCategories { get; set; } = new List<VehicleCategoryModel>();

        [Required]
        [Display(Name = "Type")]
        public int TypeId { get; set; }

        public IEnumerable<VehicleTypeModel> VehicleTypes { get; set; } = new List<VehicleTypeModel>();
    }
}
