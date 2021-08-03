namespace CarWorld.Areas.Administration.ViewModels.AdministrationMessages
{
    using System.Collections.Generic;

    public class UserMessagesViewModel
    {
        public UserMessagesViewModel()
        {
            this.Messages = new HashSet<UserMessageViewModel>();
        }

        public IEnumerable<UserMessageViewModel> Messages { get; set; }
    }
}
