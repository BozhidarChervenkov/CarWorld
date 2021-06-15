namespace CarWorld.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using CarWorld.Services.Car;
    using CarWorld.ViewModels.CarViewModels;

    public class CarsController : Controller
    {
        private readonly ICarService carService;

        public CarsController(ICarService carService)
        {
            this.carService = carService;
        }

        [HttpGet]
        public IActionResult CarById(int id)
        {
            CarViewModel viewModel = carService.Car(id);

            return View(viewModel);
        }
    }
}
