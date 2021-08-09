namespace CarWorld.Tests.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Controllers;
    using CarWorld.ViewModels.CarViewModels;
    using CarWorld.Models;

    public class CommentsControllerTests
    {
        [Fact]
        public void CommentActionShouldAllowOnlyAuthorizedUsersAndShouldRedirectWhenValidInputIsGiven()
            => MyController<CommentsController>
            .Instance(controller => controller
                .WithData(new Car
                {
                    Id = 1,
                    Make = new Make { Name = "Test Make" },
                    Model = new Model { Name = "Test Model" },
                    BodyTypeId = 1,
                    Year = 2008,
                    Description = "Test Description"
                })
                .WithUser())
            .Calling(c => c.Comment(new CarCommentViewModel
            {
                CarId = 1,
                MainCommentId = 0,
                Message = "TestMessage",
                UserId = "TestUserId"
            }))
            .ShouldHave()
            .ActionAttributes(attribute => attribute
                .RestrictingForAuthorizedRequests()
                .RestrictingForHttpMethod(HttpMethod.Post))
            .AndAlso()
            .ShouldReturn()
            .Redirect();
    }
}
