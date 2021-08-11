namespace CarWorld.Tests.Routing
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Controllers;

    public class CategoriesControllerTests
    {
        [Fact]
        public void RouteShouldMatchAllAction()
            => MyRouting
            .Configuration()
            .ShouldMap("Categories/All")
            .To<CategoriesController>(c => c.All());
    }
}
