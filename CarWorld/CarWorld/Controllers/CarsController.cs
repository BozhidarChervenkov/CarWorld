﻿namespace CarWorld.Controllers
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

        public CarsController(ICarsService carService)
        {
            this.carService = carService;
        }

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

        //Todo: Find a way to let users delete their own cars! 
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
