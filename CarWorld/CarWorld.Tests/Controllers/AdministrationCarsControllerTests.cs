namespace CarWorld.Tests.Controllers
{

    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Areas.Administration.Controllers;
    using CarWorld.Models;

    public class AdministrationCarsControllerTests
    {
        [Fact]
        public void IndexActionShouldReturnTheCorrectView()
            => MyController<AdministrationCarsController>
            .Instance()
            .Calling(c => c.Index())
            .ShouldReturn()
            .View();

        [Theory]
        [InlineData(1)]
        public void DetailsActionShouldReturnCarViewModelWhenValidCarIdIsGiven(int validCarId)
            => MyController<AdministrationCarsController>
            .Instance(controller => controller
            .WithData(new Car
            {
                Id = 1,
                Make = new Make { Id = 1, CarId = 1, Name = "Test Make" },
                Model = new Model { Id = 1, CarId = 1, Name = "Test Model" },
                BodyType = new BodyType { Id = 1, Name = "Muscle" },
                Year = 2008,
                Description = "Test Description",
                IsDeleted = false
            }))
            .Calling(c => c.Details(validCarId))
            .ShouldReturn()
            .View(result => result.WithModelOfType<Car>());

        [Fact]
        public void DetailsActionShouldReturnNotFoundWhenInvalidCarIdIsGiven()
            => MyController<AdministrationCarsController>
            .Instance(controller => controller
            .WithData(new Car
            {
                Id = 1,
                Make = new Make { Id = 1, CarId = 1, Name = "Test Make" },
                Model = new Model { Id = 1, CarId = 1, Name = "Test Model" },
                BodyType = new BodyType { Id = 1, Name = "Muscle" },
                Year = 2008,
                Description = "Test Description",
                IsDeleted = false
            }))
            .Calling(c => c.Details(null))
            .ShouldReturn()
            .View("NotFound");

        [Fact]
        public void CreateActionShouldReturnTheCorrectView()
            => MyController<AdministrationCarsController>
            .Instance()
            .Calling(c => c.Create())
            .ShouldReturn()
            .View();

        [Fact]
        public void CreateActionOnPostShouldReturnTheCorrectView()
            => MyController<AdministrationCarsController>
            .Instance()
            .Calling(c => c.Create(new Car
            {
                Id = 1,
                MakeId = 1,
                ModelId = 1,
                BodyTypeId = 1,
                Description = "TestDescription"
            }))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                             .RestrictingForHttpMethod(HttpMethod.Post))
            .AndAlso()
            .ShouldReturn()
            .View(result => result.WithModelOfType<Car>());

        [Theory]
        [InlineData(1)]
        public void EditActionShouldReturnCorrectModelCarIfValidCarIdIsGiven(int correctCarId)
            => MyController<AdministrationCarsController>
            .Instance(controller => controller
            .WithData(new Car
            {
                Id = 1,
                Make = new Make { Id = 1, CarId = 1, Name = "Test Make" },
                Model = new Model { Id = 1, CarId = 1, Name = "Test Model" },
                BodyType = new BodyType { Id = 1, Name = "Muscle" },
                Year = 2008,
                Description = "Test Description",
                IsDeleted = false
            }))
            .Calling(c => c.Edit(correctCarId))
            .ShouldReturn()
            .View(result => result.WithModelOfType<Car>());

        [Fact]
        public void EditActionShouldReturnNotFound()
            => MyController<AdministrationCarsController>
            .Instance(controller => controller
            .WithData(new Car
            {
                Id = 1,
                Make = new Make { Id = 1, CarId = 1, Name = "Test Make" },
                Model = new Model { Id = 1, CarId = 1, Name = "Test Model" },
                BodyType = new BodyType { Id = 1, Name = "Muscle" },
                Year = 2008,
                Description = "Test Description",
                IsDeleted = false
            }))
            .Calling(c => c.Edit(null))
            .ShouldReturn()
            .View("NotFound");

        [Fact]
        public void EditActionOnPostShouldReturnNotFound()
           => MyController<AdministrationCarsController>
           .Instance(controller => controller
           .WithData())
           .Calling(c => c.Edit(5000, new Car
           {
               Id = 1,
               Make = new Make { Id = 1, CarId = 1, Name = "Test Make" },
               Model = new Model { Id = 1, CarId = 1, Name = "Test Model" },
               BodyType = new BodyType { Id = 1, Name = "Muscle" },
               Year = 2008,
               Description = "Test Description",
               IsDeleted = false
           }))
           .ShouldHave()
           .ActionAttributes(attributes => attributes
                             .RestrictingForHttpMethod(HttpMethod.Post))
           .AndAlso()
           .ShouldReturn()
           .View("NotFound");

        [Theory]
        [InlineData(1)]
        public void DeleteActionShouldReturnViewWhenCorrectCarIdIsGiven(int validCarId)
            => MyController<AdministrationCarsController>
            .Instance(controller => controller
            .WithData(new Car
            {
                Id = 1,
                Make = new Make { Id = 1, CarId = 1, Name = "Test Make" },
                Model = new Model { Id = 1, CarId = 1, Name = "Test Model" },
                BodyType = new BodyType { Id = 1, Name = "Muscle" },
                Year = 2008,
                Description = "Test Description",
                IsDeleted = false
            }))
            .Calling(c => c.Delete(validCarId))
            .ShouldReturn()
            .View(result => result.WithModelOfType<Car>());

        [Fact]
        public void DeleteActionShouldReturnNotFoundWhenInvalidCarIdIsGiven()
            => MyController<AdministrationCarsController>
            .Instance(controller => controller
            .WithData(new Car
            {
                Id = 1,
                Make = new Make { Id = 1, CarId = 1, Name = "Test Make" },
                Model = new Model { Id = 1, CarId = 1, Name = "Test Model" },
                BodyType = new BodyType { Id = 1, Name = "Muscle" },
                Year = 2008,
                Description = "Test Description",
                IsDeleted = false
            }))
            .Calling(c => c.Delete(null))
            .ShouldReturn()
            .View("NotFound");

        [Theory]
        [InlineData(1)]
        public void DeleteConfirmedActionShouldRedirectWhenCorrectCarIdIsGiven(int validCarId)
            => MyController<AdministrationCarsController>
            .Instance(controller => controller
            .WithData(new Car
            {
                Id = 1,
                Make = new Make { Id = 1, CarId = 1, Name = "Test Make" },
                Model = new Model { Id = 1, CarId = 1, Name = "Test Model" },
                BodyType = new BodyType { Id = 1, Name = "Muscle" },
                Year = 2008,
                Description = "Test Description",
                IsDeleted = true
            }))
            .Calling(c => c.DeleteConfirmed(validCarId))
            .ShouldReturn()
            .Redirect();
    }
}
