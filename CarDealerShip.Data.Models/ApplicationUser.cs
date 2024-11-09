
using Microsoft.AspNetCore.Identity;

namespace CarDealerShip.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {

        public ApplicationUser()
        {
            // ReSharper disable once VirtualMemberCallInConstructor
            this.Id = Guid.NewGuid();
        }
    }
}
