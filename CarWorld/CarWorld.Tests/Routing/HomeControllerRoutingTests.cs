namespace CarWorld.Tests.Routing
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Controllers;

    public class HomeControllerRoutingTests
    {
        [Fact]
        public void RouteShouldMatchIndexAction()
            =>MyRouting
            .Configuration()
            .ShouldMap("Home/Index")
            .To<HomeController>(c => c.Index());

        [Fact]
        public void RouteShouldMatchPrivacyAction()
            => MyRouting
            .Configuration()
            .ShouldMap("Home/Privacy")
            .To<HomeController>(c => c.Privacy());

        [Fact]
        public void RouteShouldMatchErrorAction()
            => MyRouting
            .Configuration()
            .ShouldMap("Home/Error")
            .To<HomeController>(c => c.Error());
    }
}
