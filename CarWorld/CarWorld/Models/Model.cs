namespace CarWorld.Models
{
    using System.ComponentModel.DataAnnotations;

    using static GlobalConstants.GlobalConstants;

    public class Model
    {
        [Key]
        public int Id { get; set; }

        public int CarId { get; set; }

        [Required]
        [MinLength(ModelNameMinLenght)]
        [MaxLength(ModelNameMaxLenght)]
        public string Name { get; set; }
    }
}
