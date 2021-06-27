﻿namespace CarWorld.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using CarWorld.Models;
    using CarWorld.Services.Car;
    using CarWorld.ViewModels.CreateCarViewModels;

    public class CreateCarsController : Controller
    {
        private readonly ICreateCarService carsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CreateCarsController(ICreateCarService service, UserManager<ApplicationUser> userManager)
        {
            this.carsService = service;
            this.userManager = userManager;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Add()
        {
            ViewBag.BodyTypesSelectList = carsService.BodyTypesSelectList();

            return this.View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(CreateCarInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                return this.View(inputModel);
            }

            var userId = this.userManager.GetUserId(this.User);

            this.carsService.CreateCarAndAddToDb(inputModel, userId);

            return this.Redirect("~/Home/Index");
        }
    }
}
