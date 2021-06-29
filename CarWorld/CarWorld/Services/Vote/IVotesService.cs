namespace CarWorld.Services.Vote
{
    using System.Threading.Tasks;

    public interface IVotesService
    {
        /// <summary>
        ///     
        /// </summary>
        /// <param name="carId"></param>
        /// <param name="userId"></param>
        /// <param name="IsUpVote"> If true - upvote, else - downvote</param>
        /// <returns></returns>
        
        Task VoteAsync(int carId, string userId, bool isUpVote);

        int GetVotes(int carId);
    }
}
