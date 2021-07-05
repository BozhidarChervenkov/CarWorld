namespace CarWorld.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using CarWorld.Services.Car;
    using CarWorld.Services.Categories;
    using CarWorld.ViewModels.CarViewModels;

    using static GlobalConstants.GlobalConstants;

    public class CategoriesController : Controller
    {
        private readonly ICarsService carService;
        private readonly ICategoryService categoryService;      

        public CategoriesController(ICarsService carService, ICategoryService categoryService)
        {
            this.carService = carService;
            this.categoryService = categoryService;   
        }

        [HttpGet]
        public IActionResult All()
        {
            var viewModel = categoryService.Categories();

            return this.View(viewModel);
        }

        [HttpGet]
        public IActionResult CarsByCategory(int id, int pageId = MinStartingPageNumber)
        {
            var viewModel = new CarsListViewModel
            {
                Cars = this.categoryService.GetAll(pageId, id, MaxCarsPerPageCount),
                PageNumber = pageId,
                ItemsPerPage = MaxCarsPerPageCount,
                DbCarsCount = this.carService.DbCarsCount(),
                BodyTypeName = this.carService.BodyTypeName(id)
            };

            return this.View(viewModel);
        }
    }
}
