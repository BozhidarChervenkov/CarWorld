namespace CarWorld.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using CarWorld.GlobalConstants;
    using CarWorld.Services.Car;
    using CarWorld.ViewModels.CarViewModels;

    public class CarsController : Controller
    {
        private readonly ICarsService carService;

        public CarsController(ICarsService carService)
        {
            this.carService = carService;
        }

        [HttpGet]
        public IActionResult CarById(int id)
        {
            var viewModel = carService.Car(id);

            return this.View(viewModel);
        }

        // Example: Cars/All/{pageNumber}
        [HttpGet]
        public IActionResult All(int id = GlobalConstants.MinStartingPageNumber)
        {
            var viewModel = new CarsListViewModel
            {
                Cars = this.carService.GetAll(id, GlobalConstants.MaxCarsPerPageCount),
                PageNumber = id,
                ItemsPerPage = GlobalConstants.MaxCarsPerPageCount,
                DbCarsCount = this.carService.DbCarsCount()
            };

            return this.View(viewModel);
        }
    }
}
