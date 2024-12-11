using CarDealership.Data.Models;
using CarDealership.Data.Repository.Interfaces;
using CarDealership.Services.Data;
using MockQueryable.Moq;
using Moq;

namespace CarDealership.Services.Tests
{
    [TestFixture]
public class ManagerServiceTests
    {
        private Mock<IRepository<Manager, Guid>> _mockRepository;
        private ManagerService _managerService;

        [SetUp]
        public void SetUp()
        {
            _mockRepository = new Mock<IRepository<Manager, Guid>>();
            _managerService = new ManagerService(_mockRepository.Object);
        }

        [Test]
        public async Task ExistById_ReturnsTrue_WhenUserExists()
        {
            var userId = "12345";
            var managers = new List<Manager>
        {
            new Manager { UserId = Guid.NewGuid(), PhoneNumber = "123456789" }
        }.AsQueryable();

            _mockRepository.Setup(r => r.GetAllAttached())
                .Returns(managers.BuildMockDbSet().Object);

            var result = await _managerService.ExistById(userId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task ExistById_ReturnsFalse_WhenUserDoesNotExist()
        {
            var userId = "12345";
            var managers = new List<Manager>().AsQueryable();

            _mockRepository.Setup(r => r.GetAllAttached())
                .Returns(managers.BuildMockDbSet().Object);

            var result = await _managerService.ExistById(userId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task ExistById_ReturnsFalse_WhenUserIdIsNullOrEmpty()
        {
            var userId = string.Empty;
            var managers = new List<Manager>().AsQueryable();

            _mockRepository.Setup(r => r.GetAllAttached())
                .Returns(managers.BuildMockDbSet().Object);

            var result = await _managerService.ExistById(userId);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task Create_AddsManager_WhenCalledWithValidParameters()
        {
            var userId = Guid.NewGuid();
            var phoneNumber = "987654321";
            _mockRepository.Setup(r => r.AddAsync(It.IsAny<Manager>())).Returns(Task.CompletedTask);

            await _managerService.Create(userId, phoneNumber);

            _mockRepository.Verify(r => r.AddAsync(It.Is<Manager>(m => m.UserId == userId && m.PhoneNumber == phoneNumber)), Times.Once);
        }

        [Test]
        public async Task UserWithPhoneNumberExist_ReturnsTrue_WhenPhoneNumberExists()
        {
            var phoneNumber = "123456789";
            var managers = new List<Manager>
        {
            new Manager { PhoneNumber = phoneNumber }
        }.AsQueryable();

            _mockRepository.Setup(r => r.AllReadonly<Manager>())
                .Returns(managers.BuildMockDbSet().Object);

            var result = await _managerService.UserWithPhoneNumberExist(phoneNumber);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task UserWithPhoneNumberExist_ReturnsFalse_WhenPhoneNumberDoesNotExist()
        {
            var phoneNumber = "123456789";
            var managers = new List<Manager>().AsQueryable();

            _mockRepository.Setup(r => r.AllReadonly<Manager>())
                .Returns(managers.BuildMockDbSet().Object);

            var result = await _managerService.UserWithPhoneNumberExist(phoneNumber);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetManagerId_ReturnsNull_WhenUserDoesNotExist()
        {
            var userId = "12345";
            _mockRepository.Setup(r => r.AllReadonly<Manager>())
                .Returns(new List<Manager>().AsQueryable().BuildMockDbSet().Object);

            var result = await _managerService.GetManagerId(userId);

            Assert.IsNull(result);
        }
    }
}
