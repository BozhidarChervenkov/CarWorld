namespace CarWorld.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
 
    using CarWorld.Models;
    using CarWorld.Services.Home;

    public class HomeController : Controller
    {
        private readonly ILatestCarsService homeService;
        private readonly ICountsService countsService;

        public HomeController(ILatestCarsService homeService, ICountsService countsService)
        {
            this.homeService = homeService;
            this.countsService = countsService;
        }

        public IActionResult Index()
        {
            var viewModel = homeService.CollectData();
            ViewBag.CountsViewModel = countsService.ReturnCounts();

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
