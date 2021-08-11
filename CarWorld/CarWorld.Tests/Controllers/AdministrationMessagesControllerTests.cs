namespace CarWorld.Tests.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Models;
    using Areas.Administration.Controllers;
    using CarWorld.Areas.Administration.ViewModels.AdministrationMessages;
    

    public class AdministrationMessagesControllerTests
    {
        [Fact]
        public void UserMessagesActionShouldReturnCorrectViewAndViewModel()
            => MyController<AdministrationMessagesController>
            .Instance(controller => controller
            .WithUser())
            .Calling(c => c.UserMessages())
            .ShouldReturn()
            .View(result => result.WithModelOfType<UserMessagesViewModel>());

        [Theory]
        [InlineData(1)]
        public void UserMessagesActionShouldRedirectIfValidUserMessageIdIsGiven(int validUserMessageId)
            => MyController<AdministrationMessagesController>
            .Instance(controller => controller
            .WithData(new UserMessage { Id = 1, MessageContent = "TestMessageContent" })
            .WithUser())
            .Calling(c => c.Delete(validUserMessageId))
            .ShouldReturn()
            .Redirect();

        [Theory]
        [InlineData(5000)]
        public void UserMessagesActionShouldReturnNotFoundIfInvalidUserMessageIdIsGiven(int invalidUserMessageId)
            => MyController<AdministrationMessagesController>
            .Instance(controller => controller
            .WithData(new UserMessage { Id = 1, MessageContent = "TestMessageContent"})
            .WithUser())
            .Calling(c => c.Delete(invalidUserMessageId))
            .ShouldReturn()
            .View("NotFound");
    }
}
