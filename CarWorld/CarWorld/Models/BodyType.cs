namespace CarWorld.Models
{
    using System.ComponentModel.DataAnnotations;

    using GlobalConstants;

    public class BodyType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(GlobalConstants.BodyTypeNameMinLenght)]
        [MaxLength(GlobalConstants.BodyTypeNameMaxLenght)]
        public string Name { get; set; }
    }
}