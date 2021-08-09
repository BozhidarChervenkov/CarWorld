namespace CarWorld.Tests.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Controllers;
    using CarWorld.ViewModels.CategoriesViewModels;
    using CarWorld.Models;
    using CarWorld.ViewModels.CarViewModels;

    public class CategoriesControllerTests
    {
        [Fact]
        public void AllActionOnGetShouldReturnView()
            => MyController<CategoriesController>
            .Instance()
            .Calling(c => c.All())
            .ShouldHave()
            .ActionAttributes(attribute => attribute
                .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .View(result => result
                .WithModelOfType<CategoriesInListViewModel>());

        [Theory]
        [InlineData(1,1)]
        public void CarsByCategoryOnGetShouldReturnCorrectModel(int categoryId, int startingPageId)
            => MyController<CategoriesController>
            .Instance(controller=>controller
                .WithData(new Car
                {
                    Id = 1,
                    Make = new Make { Name = "Test Make" },
                    Model = new Model { Name = "Test Model" },
                    BodyTypeId = 1,
                    Year = 2008,
                    Description = "Test Description"
                },
                new BodyType 
                { 
                    Id = 1,
                    Name = "TestBodyType"
                }))
            .Calling(c => c.CarsByCategory(categoryId, startingPageId))
            .ShouldHave()
            .ActionAttributes(attribute => attribute
                .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .View(result=> result
                .WithModelOfType<CarsListViewModel>());

        [Theory]
        [InlineData(5000, 1)]
        public void CarsByCategoryOnGetShouldNotFoundIfInvalidCategoryIdIsProvided(int invalidCategoryId, int startingPageId)
            => MyController<CategoriesController>
            .Instance(controller => controller
                .WithData(new Car
                {
                    Id = 1,
                    Make = new Make { Name = "Test Make" },
                    Model = new Model { Name = "Test Model" },
                    BodyTypeId = 1,
                    Year = 2008,
                    Description = "Test Description"
                },
                new BodyType
                {
                    Id = 1,
                    Name = "TestBodyType"
                }))
            .Calling(c => c.CarsByCategory(invalidCategoryId, startingPageId))
            .ShouldHave()
            .ActionAttributes(attribute => attribute
                .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .View("NotFound");
    }
}
