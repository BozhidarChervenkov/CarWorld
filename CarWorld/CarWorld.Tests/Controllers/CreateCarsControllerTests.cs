namespace CarWorld.Tests.Controllers
{
    using System.Linq;
    using Xunit;
    using Shouldly;
    using MyTested.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    using CarWorld.Models;
    using CarWorld.Controllers;
    using CarWorld.ViewModels.CreateCarViewModels;
    

    public class CreateCarsControllerTests
    {
        [Fact]
        public void AddActionOnGetShouldAllowOnlyAuthorizedUsersAndShouldReturnView()
            => MyController<CreateCarsController>
            .Instance()
            .Calling(c => c.Add())
            .ShouldHave()
            .ActionAttributes(attributes => attributes
            .RestrictingForAuthorizedRequests()
            .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldHave()
            .ViewBag(viewBag => viewBag.ContainingEntryOfType<SelectList>())
            .AndAlso()
                .ShouldReturn()
                .View();

        [Fact]
        public void AddActionOnPostShouldReturnViewWithTheSameModelWhenModelStateIsInvalid()
            => MyController<CreateCarsController>
            .Instance()
            .WithUser()
            .Calling(c => c.Add(With.Default<CreateCarInputModel>()))
            .ShouldHave()
            .InvalidModelState()
            .AndAlso()
            .ShouldReturn()
            .View(result => result.WithModelOfType<CreateCarInputModel>());

        [Theory]
        [InlineData("Test Make", "Test Model", "Test Description", 1, 2008, 30000)]
        public void AddActionOnPostShouldAddCarToDbWhenModelstateIsValidAndRedirectToAction(
            string Make,
            string Model,
            string Description,
            int BodyTypeId,
            int Year,
            decimal Price
            )
            => MyController<CreateCarsController>
            .Instance()
            .WithUser()
            .Calling(c => c.Add(new CreateCarInputModel
            {
                Make = new Make { Name = Make },
                Model = new Model { Name = Model },
                Description = Description,
                BodyTypeId = BodyTypeId,
                Year = Year,
                Price = Price
            }))
            .ShouldHave()
            .Data(data=>data
                        .WithSet<Car>(set=> 
                        {
                            set.ShouldNotBeNull();
                            set.FirstOrDefault();
                        }))
            .AndAlso()
            .ShouldHave()
            .ValidModelState()
            .AndAlso()
            .ShouldReturn()
            .Redirect();
    }
}
