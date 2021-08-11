namespace CarWorld.Tests.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Controllers;
    using CarWorld.ViewModels.SearchCarViewModels;

    public class SearchControllerTests
    {
        [Fact]
        public void SearchForCarsActionOnGetShouldReturnView()
            => MyController<SearchController>
            .Instance()
            .Calling(c => c.SearchForCars())
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForHttpMethod(HttpMethod.Get))
            .AndAlso()
            .ShouldReturn()
            .View();

        [Fact]
        public void SearchForCarsActionOnPostShouldRedirectWhenGivenDataIsNotValid()
            => MyController<SearchController>
            .Instance()
            .Calling(c => c.SearchForCars( new SearchCarInputModel { SearchTerm =""}))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForHttpMethod(HttpMethod.Post))
            .AndAlso()
            .ShouldReturn()
            .Redirect();
    }
}
