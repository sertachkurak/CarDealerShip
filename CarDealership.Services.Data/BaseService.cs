using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.Services.Data.Interfaces;

namespace CarDealership.Services.Data
{
    public class BaseService : IBaseService
    {
        public bool IsGuidValid(string? id, ref Guid parsedGuid)
        {
            if (String.IsNullOrWhiteSpace(id))
            {
                return false;
            }

            bool isValidGuid = Guid.TryParse(id, out parsedGuid);

            if (!isValidGuid)
            {
                return false;
            }

            return true;
        }
    }
}
