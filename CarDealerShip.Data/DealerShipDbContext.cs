using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarDealerShip.Data
{
    public class DealerShipDbContext : IdentityDbContext
    {

        public DealerShipDbContext()
        {
            
        }


        public DealerShipDbContext(DbContextOptions options)
                :base(options)
        {
            
        }
    }
}
