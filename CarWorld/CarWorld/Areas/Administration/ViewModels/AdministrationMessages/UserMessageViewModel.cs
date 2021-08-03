namespace CarWorld.Areas.Administration.ViewModels.AdministrationMessages
{
    using System;

    public class UserMessageViewModel
    {
        public int MessageId { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }
        
        public string MessageContent { get; set; }

        public DateTime SentAtDate { get; set; }
    }
}
