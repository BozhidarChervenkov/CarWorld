namespace CarWorld.Models
{
    using System.ComponentModel.DataAnnotations;

    using static GlobalConstants.GlobalConstants;

    public class BodyType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(BodyTypeNameMinLenght)]
        [MaxLength(BodyTypeNameMaxLenght)]
        public string Name { get; set; }

        public string PictureUrl { get; set; }
    }
}