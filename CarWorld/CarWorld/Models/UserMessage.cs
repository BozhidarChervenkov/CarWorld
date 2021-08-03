namespace CarWorld.Models
{
    using System;

    public class UserMessage
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string MessageContent { get; set; }

        public DateTime SentAtDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
