namespace CarWorld.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Video
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UrlPath { get; set; }

        public int ShowId { get; set; }

        public Show Show { get; set; }
    }
}
