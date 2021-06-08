namespace CarWorld.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using CarWorld.Models;
    using CarWorld.Services.Car;
    using CarWorld.ViewModels.CarViewModels;

    public class CarsController : Controller
    {
        private readonly ICarService carsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CarsController(ICarService service, UserManager<ApplicationUser> userManager)
        {
            this.carsService = service;
            this.userManager = userManager;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Add()
        {
            ViewBag.BodyTypesSelectList = carsService.BodyTypesSelectList();
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(AddCarInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return View(inputModel);
            }

            var userId = this.userManager.GetUserId(this.User);

            this.carsService.CreateCarAndAddToDb(inputModel, userId);

            return View("/"); 
        }
    }
}
