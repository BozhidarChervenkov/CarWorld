﻿namespace CarWorld.Tests.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Models;
    using CarWorld.Controllers;

    using CarWorld.ViewModels.CarViewModels;

    public class CarsControllerTests
    {
        [Theory]
        [InlineData(1)]
        public void CarByIdActionOnGetShouldAllowOnlyAuthorizedUsersAndShouldReturnView(int validCarId)
            => MyController<CarsController>
            .Instance(controller => controller
                    .WithData(new Car
                    {
                        Id = 1,
                        Make = new Make { Id = 1, CarId = 1, Name = "Test Make" },
                        Model = new Model { Id = 1, CarId = 1, Name = "Test Model" },
                        BodyType= new BodyType { Id = 1, Name = "TestBodyTypeName"},
                        Year = 2008,
                        Description = "Test Description",
                        IsDeleted = false
                    })
                    .WithUser())
            .Calling(c => c.CarById(validCarId))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForAuthorizedRequests()
                .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .View(result => result.WithModelOfType<CarViewModel>());

        [Fact]
        public void AllShouldReturnView()
        => MyController<CarsController>
            .Instance()
            .Calling(c => c.All(2))
            .ShouldReturn()
            .View();

        [Theory]
        [InlineData(5000)]
        public void EditActionOnGetShouldReturnNotFoundViewWhenInvalidCarIdIsGiven(int invalidCarId)
        => MyController<CarsController>
            .Instance()
            .WithUser()
            .Calling(c => c.Edit(invalidCarId))
            .ShouldHave()
            .ViewBag(viewBag => viewBag.ContainingEntryOfType<string>())
            .AndAlso()
            .ShouldReturn()
            .View("NotFound");

        [Fact]
        public void EditActionOnPostShouldReturnNotFoundViewWhenInvalidCarIdIsGiven()
        => MyController<CarsController>
            .Instance()
            .WithUser()
            .Calling(c => c.Edit(new CarEditViewModel 
            {
                CarId = 1,
            }))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForAuthorizedRequests()
                .RestrictingForHttpMethod(HttpMethod.Post))
            .AndAlso()
            .ShouldReturn()
            .View("NotFound");

        [Theory]
        [InlineData(1)]
        public void DeleteShouldAllowOnlyAuthorizedUsersAndShouldRedirectToAction(int validCarId)
            => MyController<CarsController>
            .Instance(controller => controller
                    .WithData(new Car
                    {
                        Id = 1,
                        MakeId = 1,
                        ModelId = 1,
                        BodyTypeId = 1,
                        Year = 2008,
                        Description = "Test Description",
                        IsDeleted = false
                    },
                    new Make { Id = 1, CarId = 1, Name = "Test Make" },
                    new Model { Id = 1, CarId = 1, Name = "Test Model" }
                    )
                    .WithUser())
            .Calling(c => c.Delete(validCarId))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
            .RestrictingForAuthorizedRequests()
            .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .Redirect();

        [Theory]
        [InlineData(5000)]
        public void DeleteShouldAllowOnlyAuthorizedUsersAndShouldReturnNotFoundWhenInvalidCarIdIsGiven(int inValidCarId)
            => MyController<CarsController>
            .Instance(controller => controller
                    .WithData(new Car
                    {
                        Id = 1,
                        MakeId = 1,
                        ModelId = 1,
                        BodyTypeId = 1,
                        Year = 2008,
                        Description = "Test Description",
                        IsDeleted = false
                    },
                    new Make { Id = 1, CarId = 1, Name = "Test Make" },
                    new Model { Id = 1, CarId = 1, Name = "Test Model" }
                    )
                    .WithUser())
            .Calling(c => c.Delete(inValidCarId))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
            .RestrictingForAuthorizedRequests()
            .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .View("NotFound");
    }
}
