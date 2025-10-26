using CarDealership.Data.Models;
using CarDealership.Data.Repository.Interfaces;
using CarDealership.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Services.Data
{
    public class ManagerService : BaseService, IManagerService
    {
        private readonly IRepository<Manager, Guid> managersRepository;

        public ManagerService(IRepository<Manager, Guid> managersRepository)
        {
            this.managersRepository = managersRepository;
        }

        public async Task<bool> ExistById(string? userId)
        {
            if (String.IsNullOrWhiteSpace(userId))
            {
                return false;
            }

            bool result = await this.managersRepository
                .GetAllAttached()
                .AnyAsync(m => m.UserId.ToString().ToLower() == userId);

            return result;
        }

        public async Task Create(Guid userId, string phoneNumber)
        {
            Manager manager = new Manager()
            {
                UserId = userId,
                PhoneNumber = phoneNumber
            };

            await managersRepository.AddAsync(manager);
        }

        public async Task<bool> UserWithPhoneNumberExist(string phoneNumber)
        {
            return await managersRepository.AllReadonly<Manager>()
                .AnyAsync(m => m.PhoneNumber == phoneNumber);
        }

        public async Task<Guid> GetManagerId(string userId)
        {
            Guid userGuid = Guid.Parse(userId);

            var manager = await managersRepository.AllReadonly<Manager>()
                .FirstOrDefaultAsync(m => m.UserId == userGuid);

            return manager?.Id ?? Guid.Empty;
        }
    }
}
