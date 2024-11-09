using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip.Data.Models
{
    using static Common.Constants.VehicleCategoryValidations;
    public class VehicleCategory
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public List<Vehicle> Vehicles { get; set; }
            = new List<Vehicle>();
    }
}
