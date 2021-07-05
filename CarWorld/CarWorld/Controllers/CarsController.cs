namespace CarWorld.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;

    using CarWorld.Services.Car;
    using CarWorld.ViewModels.CarViewModels;

    using static GlobalConstants.GlobalConstants;

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

            if (viewModel == null)
            {
                ViewBag.ErrorMessage = $"Car with id {id} cannot be found!";
                return this.View("NotFound");
            }

            return this.View(viewModel);
        }

        // Example: Cars/All/{pageNumber}
        [HttpGet]
        public IActionResult All(int id = MinStartingPageNumber)
        {
            var viewModel = new CarsListViewModel
            {
                Cars = this.carService.GetAll(id, MaxCarsPerPageCount),
                PageNumber = id,
                ItemsPerPage = MaxCarsPerPageCount,
                DbCarsCount = this.carService.DbCarsCount()
            };

            return this.View(viewModel);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> DeleteCar(int id)
        {
            var isCarDeleted = this.carService.DeleteCar(id);

            if (await isCarDeleted == false)
            {
                ViewBag.ErrorMessage = $"Car with id {id} cannot be found!";
                return this.View("NotFound");
            }

            return this.RedirectToAction("All", "Cars");
        }
    }
}
