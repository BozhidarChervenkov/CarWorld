namespace CarWorld.Services.Home
{
    using CarWorld.Data;
    using CarWorld.Models;
    using CarWorld.ViewModels.HomePageViewModels;

    public class UserMessagesService : IUserMessagesService
    {
        private readonly ApplicationDbContext context;

        public UserMessagesService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Save(IndexViewModel input)
        {
            var userMessage = new UserMessage
            {
                UserId = input.UserId,
                MessageContent = input.MessageContent
            };

            this.context.UserMessages.Add(userMessage);
        }
    }
}
