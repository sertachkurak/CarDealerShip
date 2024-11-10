
using Microsoft.AspNetCore.Identity;

namespace CarDealership.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {

        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
