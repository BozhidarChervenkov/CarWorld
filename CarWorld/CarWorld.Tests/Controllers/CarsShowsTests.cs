namespace CarWorld.Tests.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Controllers;
    using CarWorld.ViewModels.CarShowsViewModels;
    using CarWorld.Models;

    public class CarsShowsTests
    {
        [Fact]
        public void AllActionOnGetShouldAllowOnlyAuthorizedUsersAndShouldReturnView()
            => MyController<CarShowsController>
            .Instance(controller => controller
            .WithData(new Show { Id = 1, Title = "TestShowTitle", Description = "TestShowDescription" })
            .WithUser())
            .Calling(c => c.All())
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForAuthorizedRequests()
                .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .View(result => result.WithModelOfType<AllShowsViewModel>());

        [Theory]
        [InlineData(1)]
        public void ShowByIdActionOnGetShouldAllowAuthorizedUsersAndShouldReturnView(int validShowId)
            => MyController<CarShowsController>
            .Instance(controller => controller
            .WithData(new Show { Id = 1, Title = "TestShowTitle", Description = "TestShowDescription" })
            .WithUser())
            .Calling(c => c.ShowById(validShowId))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForAuthorizedRequests()
                .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .View(result => result.WithModelOfType<ShowByIdViewModel>());

        [Theory]
        [InlineData(5000)]
        public void ShowByIdActionOnGetShouldNotFoundIfInvalidShowIdIsGiven(int inValidShowId)
            => MyController<CarShowsController>
            .Instance(controller => controller
            .WithData(new Show { Id = 1, Title = "TestShowTitle", Description = "TestShowDescription" })
            .WithUser())
            .Calling(c => c.ShowById(inValidShowId))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForAuthorizedRequests()
                .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .View("NotFound");

        [Fact]
        public void AddActionOnGetShouldAllowOnlyAdminRoleAndShouldReturnView()
            => MyController<CarShowsController>
            .Instance()
            .Calling(c => c.Add())
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForAuthorizedRequests()
                .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .View();

        [Fact]
        public void AddActionOnPostShouldAllowOnlyAdminRoleAndShouldRedirect()
            => MyController<CarShowsController>
            .Instance()
            .Calling(c => c.Add(new AddShowInputModel { Id = 1, Title = "TestShowTitle", Description = "TestShowDescription" }))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForAuthorizedRequests()
                .RestrictingForHttpMethod(HttpMethod.Post))
            .AndAlso()
            .ShouldReturn()
            .Redirect();

        [Theory]
        [InlineData(1)]
        public void DeleteActionOnGetShouldAuthorizeOnlyAdminRoleAndShouldRedirect(int validShowId)
            => MyController<CarShowsController>
            .Instance(controller => controller
            .WithData(new Show { Id = 1, Title = "TestShowTitle", Description = "TestShowDescription" }))
            .Calling(c => c.DeleteShow(validShowId))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForAuthorizedRequests()
                .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .Redirect();

        [Theory]
        [InlineData(5000)]
        public void DeleteActionOnGetShouldAuthorizeOnlyAdminRoleAndShouldReturnNotFoundWhenInvaidShowIdIsGiven(int inValidShowId)
            => MyController<CarShowsController>
            .Instance(controller => controller
            .WithData(new Show { Id = 1, Title = "TestShowTitle", Description = "TestShowDescription" }))
            .Calling(c => c.DeleteShow(inValidShowId))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForAuthorizedRequests()
                .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .View("NotFound");
    }
}
