namespace CarWorld.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using CarWorld.Models;
    using CarWorld.Services.Car;
    using CarWorld.ViewModels.CreateCarViewModels;

    public class CreateCarController : Controller
    {
        private readonly ICreateCarService carsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CreateCarController(ICreateCarService service, UserManager<ApplicationUser> userManager)
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
        public IActionResult Add(CreateCarInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return View(inputModel);
            }

            var userId = this.userManager.GetUserId(this.User);

            this.carsService.CreateCarAndAddToDb(inputModel, userId);

            return Redirect("~/Home/Index");
        }
    }
}
