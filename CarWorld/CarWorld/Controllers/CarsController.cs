namespace CarWorld.Controllers
{
    using CarWorld.Services.Car;
    using CarWorld.ViewModels.CarViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class CarsController : Controller
    {
        private readonly ICarService carsService;

        public CarsController(ICarService service)
        {
            this.carsService = service;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Add()
        {
            ViewBag.BodyTypesList = carsService.BodyTypesList();
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Add(AddCarInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return View(inputModel);
            }

            this.carsService.CreateCarAndAddToDb(inputModel);

            return View("/");
        }
    }
}
