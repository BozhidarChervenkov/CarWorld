namespace CarWorld.Models
{
    using System.ComponentModel.DataAnnotations;

    using static GlobalConstants.GlobalConstants;

    public class Picture
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(PictureUrlMinLenght)]
        [MaxLength(PictureUrlMaxLenght)]
        public string Url { get; set; }

        public int? CarId { get; set; }

        public Car Car { get; set; }
    }
}
