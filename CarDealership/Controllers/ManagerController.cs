using CarDealership.Common;
using CarDealership.Services.Data.Interfaces;
using CarDealership.Web.Infrastructure;
using CarDealership.Web.ViewModels.Manager;
using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Web.Controllers
{

    public class ManagerController : BaseController
    {
        private readonly IManagerService managerService;


        public ManagerController(IManagerService managerService)
            :base(managerService)
        {
            this.managerService = managerService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await managerService.ExistById(User.GetUserId()))
            {
                TempData[Constants.MessageConstants.ErrorMessage] = "Вие вече сте Мениджър";

                return RedirectToAction("Index", "Home");
            }

            var model = new BecomeManagerViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeManagerViewModel becomeManager)
        {
            Guid userId = new Guid(User.GetUserId());

            if (!ModelState.IsValid)
            {
                return View(becomeManager);
            }

            if (await managerService.ExistById(userId.ToString()))
            {
                TempData[Constants.MessageConstants.ErrorMessage] = "Вие вече сте Мениджър";

                return RedirectToAction("Index", "Home");
            }

            if (await managerService.UserWithPhoneNumberExist(becomeManager.PhoneNumber))
            {
                TempData[Constants.MessageConstants.ErrorMessage] = "Телефона вече съществува";

                return RedirectToAction("Index", "Home");
            }

            await managerService.Create(userId, becomeManager.PhoneNumber);

            return RedirectToAction("Index", "Vehicle");
        }
    }
}
