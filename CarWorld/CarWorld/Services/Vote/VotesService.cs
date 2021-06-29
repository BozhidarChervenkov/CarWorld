namespace CarWorld.Services.Vote
{
    using System.Linq;
    using System.Threading.Tasks;

    using CarWorld.Data;
    using CarWorld.Models;

    public class VotesService : IVotesService
    {
        private readonly ApplicationDbContext context;
        public VotesService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task VoteAsync(int carId, string userId, bool isUpVote)
        {
            var vote = this.context.Votes
                .FirstOrDefault(v => v.CarId == carId && v.UserId == userId);

            if (vote != null)
            {
                vote.Type = isUpVote ? VoteType.Upvote : VoteType.DownVote;
            }
            else
            {
                vote = new Vote()
                {
                    CarId = carId,
                    UserId = userId,
                    Type = isUpVote ? VoteType.Upvote : VoteType.DownVote
                };

                await this.context.Votes.AddAsync(vote);
            }

            await this.context.SaveChangesAsync();
        }

        public int GetVotes(int carId)
        {
            var votes = this.context.Votes.Where(v => v.CarId == carId).Sum(v => (int)v.Type);

            return votes;
        }
    }
}
