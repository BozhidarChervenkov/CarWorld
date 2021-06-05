namespace CarWorld.Models
{
    using System.ComponentModel.DataAnnotations;

    using GlobalConstants;

    public class Model
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(GlobalConstants.ModelNameMinLenght)]
        [MaxLength(GlobalConstants.ModelNameMaxLenght)]
        public string Name { get; set; }
    }
}
