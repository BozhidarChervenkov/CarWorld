namespace CarWorld.Tests.Controllers
{
    using Xunit;
    using MyTested.AspNetCore.Mvc;

    using CarWorld.Controllers;
    using CarWorld.ViewModels.VotesViewModels;

    public class VotesControllerTests
    {
        [Fact]
        public void PostActionOnPostShouldAllowOnlyAuthorizedUsersAndShouldReturnVoteResponseModel()
            => MyController<VotesController>
            .Instance(controller => controller
                .WithUser())
            .Calling(c => c.Post(new VoteInputModel
            {
                CarId = 1,
                IsUpVote = true
            }))
            .ShouldHave()
            .ActionAttributes(attributes => attributes
            .RestrictingForAuthorizedRequests()
            .RestrictingForHttpMethod(HttpMethod.Post))
            .AndAlso()
            .ShouldReturn()
            .Object();
    }
}
