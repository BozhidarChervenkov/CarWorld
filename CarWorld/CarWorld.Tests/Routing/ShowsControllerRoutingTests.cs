namespace CarWorld.Tests.Routing
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Controllers;

    public class ShowsControllerRoutingTests
    {
        [Fact]
        public void RouteShouldMatchAllAction()
            => MyRouting
            .Configuration()
            .ShouldMap("CarShows/All")
            .To<CarShowsController>(c => c.All());

        [Fact]
        public void RouteShouldMatchAddAction()
            => MyRouting
            .Configuration()
            .ShouldMap("CarShows/Add")
            .To<CarShowsController>(c => c.Add());

        [Fact]
        public void RouteShouldDeleteShowAction()
            => MyRouting
            .Configuration()
            .ShouldMap("CarShows/DeleteShow/1")
            .To<CarShowsController>(c => c.DeleteShow(1));
    }
}
