namespace CarWorld.Models
{
    using System;

    public class Comment
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
