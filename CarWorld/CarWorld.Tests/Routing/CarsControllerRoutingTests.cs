namespace CarWorld.Tests.Routing
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Controllers;

    public class CarsControllerRoutingTests
    {
        [Fact]
        public void RouteShouldMatchCarByIdActionWithParameter()
            => MyRouting
            .Configuration()
            .ShouldMap("Cars/CarById/1")
            .To<CarsController>(c => c.CarById(1));

        [Fact]
        public void RouteShouldMatchAllAction()
            => MyRouting
            .Configuration()
            .ShouldMap("Cars/All/1")
            .To<CarsController>(c => c.All(1));

        [Fact]
        public void RouteShouldMatchEditAction()
            => MyRouting
            .Configuration()
            .ShouldMap("Cars/Edit/1")
            .To<CarsController>(c => c.Edit(1));

        [Fact]
        public void RouteShouldMatchDeleteAction()
            => MyRouting
            .Configuration()
            .ShouldMap("Cars/Delete/1")
            .To<CarsController>(c => c.Delete(1));
    }
}
