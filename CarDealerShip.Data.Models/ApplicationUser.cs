
using Microsoft.AspNetCore.Identity;

namespace CarDealership.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {

        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
        }

        public virtual ICollection<ApplicationUserVehicle> ApplicationUserVehicles { get; set; }
            = new HashSet<ApplicationUserVehicle>();
    }
}
