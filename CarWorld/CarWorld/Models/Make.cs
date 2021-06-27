namespace CarWorld.Models
{
    using System.ComponentModel.DataAnnotations;

    using static GlobalConstants.GlobalConstants;

    public class Make
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(MakeNameMinLenght)]
        [MaxLength(MakeNameMaxLenght)]
        public string Name { get; set; }
    }
}