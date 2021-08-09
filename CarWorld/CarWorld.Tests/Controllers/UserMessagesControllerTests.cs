namespace CarWorld.Tests.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Controllers;
    using CarWorld.ViewModels.HomePageViewModels;

    public class UserMessagesControllerTests
    {
        [Fact]
        public void SaveMessageActionOnPostShouldAllowOnlyAuthorizedUsersAndReturnView()
            => MyController<UserMessagesController>
            .Instance(controller => controller
                .WithUser())
            .Calling(c => c.SaveMessage(new IndexViewModel
            {
                UserId = "TestUserId",
                MessageContent = "TestMessageContent"
            }))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
                .RestrictingForAuthorizedRequests()
                .RestrictingForHttpMethod(HttpMethod.Post))
            .AndAlso()
            .ShouldReturn()
            .View("MessageSent");
    }
}
