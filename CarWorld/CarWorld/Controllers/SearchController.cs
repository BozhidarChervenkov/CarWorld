namespace CarWorld.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using CarWorld.Services.SearchCars;
    using CarWorld.ViewModels.SearchCarViewModels;

    public class SearchController : Controller
    {
        private readonly ISearchService searchService;

        public SearchController(ISearchService searchService)
        {
            this.searchService = searchService;
        }

        [HttpGet]
        public IActionResult SearchForCars()
        {
            // Creating an empty instance to ititialize the collections
            SearchCarInputModel input = new SearchCarInputModel();

            return this.View(input);
        }

        [HttpPost]
        public IActionResult SearchForCars(SearchCarInputModel input)
        {
            if (string.IsNullOrWhiteSpace(input.SearchTerm))
            {
                return this.RedirectToAction("SearchForCars");
            }

            if (this.searchService.DoesModelOrNameExist(input.SearchTerm) == false)
            {
                ViewBag.ErrorMessage = $"Car with make or model name '{input.SearchTerm}' cannot be found!";
                return this.View("NotFound");
            }

            var cars = this.searchService.Search(input.SearchTerm);

            input.SearchResult = cars;

            return this.View(input);
        }
    }
}
