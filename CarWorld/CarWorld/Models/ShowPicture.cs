namespace CarWorld.Models
{
    using System.ComponentModel.DataAnnotations;

    using static GlobalConstants.GlobalConstants;

    public class ShowPicture
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(PictureUrlMinLenght)]
        [MaxLength(PictureUrlMaxLenght)]
        public string Url { get; set; }

        [Required]
        public int ShowId { get; set; }

        public Show Show { get; set; }
    }
}
