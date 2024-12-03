using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.Data.Models;

namespace CarDealership.Services.Data.Interfaces
{
    public interface IManagerService
    {
        Task<bool> ExistById(string? userId);

        Task Create(Guid userId, string phoneNumber);

        Task<bool> UserWithPhoneNumberExist(string phoneNumber);

        Task<Manager?> GetManagerId(string userId);
    }
}
