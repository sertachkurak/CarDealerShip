using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.Web.ViewModels.Vehicle;

namespace CarDealership.Web.ViewModels.Admin
{
    public class AdminVehicleViewModel
    {
        public IEnumerable<VehicleServiceModel> AddedVehicles { get; set; }
            = new List<VehicleServiceModel>();
    }
}
