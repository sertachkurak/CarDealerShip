using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Data.Models
{
    public class ApplicationUserVehicle
    {
        public Guid ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public Guid VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; } = null!;
    }
}
