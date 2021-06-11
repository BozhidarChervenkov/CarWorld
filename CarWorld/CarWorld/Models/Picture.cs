namespace CarWorld.Models
{
    using System.ComponentModel.DataAnnotations;

    using GlobalConstants;

    public class Picture
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(GlobalConstants.PictureUrlMinLenght)]
        [MaxLength(GlobalConstants.PictureUrlMaxLenght)]
        public string Url { get; set; }

        public int? CarId { get; set; }

        public Car Car { get; set; }
    }
}
