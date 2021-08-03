namespace CarWorld.Services.Home
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using CarWorld.Areas.Administration.ViewModels.AdministrationMessages;
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
                MessageContent = input.MessageContent,
                SentAtDate = DateTime.Now
            };

            this.context.UserMessages.Add(userMessage);
            this.context.SaveChanges();
        }

        public async Task<bool> Delete(int id)
        {
            var userMessage = this.context.UserMessages.FirstOrDefault(um => um.Id == id);

            if (userMessage == null)
            {
                return false;
            }

            userMessage.IsDeleted = true;
            await this.context.SaveChangesAsync();
            return true;
        }

        public UserMessagesViewModel All()
        {
            var userMessages = this.context.UserMessages
                .Where(um => um.IsDeleted == false)
                .Select(um => new UserMessageViewModel
                {
                    MessageId = um.Id,
                    UserId = um.UserId,
                    MessageContent = um.MessageContent,
                    SentAtDate = um.SentAtDate,
                    UserName = this.context.Users.FirstOrDefault(u => u.Id == um.UserId).UserName
                })
            .ToList();

            UserMessagesViewModel viewModel = new UserMessagesViewModel
            {
                Messages = userMessages
            };

            return viewModel;
        }
    }
}
