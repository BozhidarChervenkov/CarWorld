namespace CarWorld.Tests.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Controllers;
    using CarWorld.ViewModels.HomePageViewModels;

    using static CarWorld.Tests.Data.Cars;
    
    public class HomeControllerTests
    {
        [Fact]
        public void IndexShouldReturnCorrectViewWithModel()
            => MyController<HomeController>
                .Instance(controller => controller
                    .WithData(TenCars))
                .Calling(c => c.Index())
                .ShouldHave()
                    .ViewBag(viewBag => viewBag.ContainingEntryOfType<CountsViewModel>())
                .AndAlso()
                .ShouldReturn()
                .View(view=>view.WithModelOfType<IndexViewModel>());

        [Fact]
        public void PrivacyShouldReturnView()
           => MyController<HomeController>
               .Instance()
               .Calling(c => c.Privacy())
               .ShouldReturn()
               .View();

        [Fact]
        public void ErrorShouldReturnView()
            => MyController<HomeController>
                .Instance()
                .Calling(c => c.Error())
                .ShouldReturn()
                .View();
    }
}
