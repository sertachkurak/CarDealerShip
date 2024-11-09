using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerShip.Data.Models
{
    using static Common.Constants.PurposeValidations;
    public class VehiclePurpose
    {
        public Guid Id { get; set; }

        [Required] 
        [MaxLength(NameMaxLength)] 
        public string Name { get; set; } = null!;

        public List<Vehicle> Vehicles { get; set; }
            = new List<Vehicle>();
    }
}
