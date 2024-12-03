using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Web.ViewModels.Vehicle
{
    public class VehicleIndexViewModel
    {
        public string Id { get; set; } = null!;

        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Category { get; set; } = null!;

        public IEnumerable<VehicleCategoryModel> Categories { get; set; }
            = new List<VehicleCategoryModel>();
    }
}
