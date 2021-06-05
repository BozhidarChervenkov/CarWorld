namespace CarWorld.Models
{
    using System.ComponentModel.DataAnnotations;

    using GlobalConstants;

    public class Make
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(GlobalConstants.MakeNameMinLenght)]
        [MaxLength(GlobalConstants.MakeNameMaxLenght)]
        public string Name { get; set; }
    }
}