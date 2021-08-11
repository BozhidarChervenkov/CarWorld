namespace CarWorld.Controllers
{
    using System.Security.Claims;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;

    using CarWorld.Services.Car;
    using CarWorld.ViewModels.CarViewModels;

    using static GlobalConstants.GlobalConstants;

    public class CarsController : Controller
    {
        private readonly ICarsService carService;
        private readonly ICreateCarService createCarService;

        public CarsController(ICarsService carService, ICreateCarService createCarService)
        {
            this.carService = carService;
            this.createCarService = createCarService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult CarById(int id)
        {
            var viewModel = this.carService.Car(id);

            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            viewModel.CurrentUserId = currentUserId;

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

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var doesCarExist = this.carService.DoesCarExist(id);

            if (doesCarExist == false)
            {
                ViewBag.ErrorMessage = $"Car with id: {id} cannot be found!";

                return this.View("NotFound");
            }

            var viewModel = this.carService.CarById(id);

            ViewBag.BodyTypesSelectList = this.createCarService.BodyTypesSelectList();

            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(CarEditViewModel input)
        {
            var carExists = this.carService.DoesCarExist(input.CarId);

            if (carExists == false)
            {
                ViewBag.ErrorMessage = $"Car with id {input.CarId} cannot be found!";
                return this.View("NotFound");
            }

            this.carService.Edit(input);

            return RedirectToAction("CarById", new { id = input.CarId });
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var isCarDeleted = this.carService.Delete(id);

            if (await isCarDeleted == false)
            {
                ViewBag.ErrorMessage = $"Car with id {id} cannot be found!";
                return this.View("NotFound");
            }

            return this.RedirectToAction("All", "Cars");
        }
    }
}
