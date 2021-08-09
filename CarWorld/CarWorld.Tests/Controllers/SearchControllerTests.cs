namespace CarWorld.Tests.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Controllers;

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
    }
}
