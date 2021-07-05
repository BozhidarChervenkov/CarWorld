namespace CarWorld.Models
{
    using System.Collections.Generic;

    public class MainComment : Comment
    {
        public MainComment()
        {
            this.SubComments = new HashSet<SubComment>();
        }

        public int CarId { get; set; }

        public Car Car { get; set; }

        public ICollection<SubComment> SubComments { get; set; }
    }
}
