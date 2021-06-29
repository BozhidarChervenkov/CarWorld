namespace CarWorld.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;    
    using System.Threading.Tasks;

    using CarWorld.Services.Vote;
    using CarWorld.ViewModels.VotesViewModels;
    using Microsoft.AspNetCore.Identity;
    using CarWorld.Models;

    [ApiController]
    [Route("api/[controller]")]
    public class VotesController : Controller
    {
        private readonly IVotesService votesService;
        private readonly UserManager<ApplicationUser> userManager;

        public VotesController(IVotesService votesService, UserManager<ApplicationUser> userManager)
        {
            this.votesService = votesService;
            this.userManager = userManager;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<VoteResponseModel>> Post(VoteInputModel input)
        {
            var userId = userManager.GetUserId(this.User);
            await this.votesService.VoteAsync(input.CarId, userId, input.IsUpVote);
            var votes = this.votesService.GetVotes(input.CarId);

            return new VoteResponseModel { VotesCount = votes };
        }
    }
}
