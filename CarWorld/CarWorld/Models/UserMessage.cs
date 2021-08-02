namespace CarWorld.Models
{
    public class UserMessage
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string MessageContent;
    }
}
