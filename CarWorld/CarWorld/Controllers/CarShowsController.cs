namespace CarWorld.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using CarWorld.Services.CarShows;
    using CarWorld.ViewModels.CarShowsViewModels;
    using CarWorld.Models;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class CarShowsController : Controller
    {
        private readonly ICarShowsService carShowsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CarShowsController(ICarShowsService carShowsService, UserManager<ApplicationUser> userManager)
        {
            this.carShowsService = carShowsService;
            this.userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        public IActionResult All()
        {
            var shows = this.carShowsService.AllShows();

            var allShowsViewModel = new AllShowsViewModel()
            {
                Shows = shows
            };

            return this.View(allShowsViewModel);
        }

        [Authorize]
        [HttpGet]
        public IActionResult ShowById(int id)
        {
            var viewModel = this.carShowsService.ShowById(id);

            if (viewModel == null)
            {
                ViewBag.ErrorMessage = $"Show with id {id} cannot be found!";
                return this.View("NotFound");
            }

            ViewBag.EmbeddedVideoCodes = this.carShowsService.EmbeddedVideoCodes(viewModel);

            return this.View(viewModel);
        }

        [Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Add(AddShowInputModel input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            var userId = this.userManager.GetUserId(this.User);
            this.carShowsService.AddShow(input, userId);

            return this.RedirectToAction("All", "CarShows");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> DeleteShow(int id)
        {
            var isShowDeleted = this.carShowsService.DeleteShow(id);

            if (await isShowDeleted == false)
            {
                ViewBag.ErrorMessage = $"Show with id {id} cannot be found!";
                return this.View("NotFound");
            }

            return this.RedirectToAction("All", "CarShows");
        }
    }
}
