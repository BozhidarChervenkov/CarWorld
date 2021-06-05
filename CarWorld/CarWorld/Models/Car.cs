namespace CarWorld.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CarWorld.GlobalConstants;

    public class Car
    {
        public Car()
        {
            this.CarPictures = new HashSet<CarPicture>();
        }

        [Key]
        public int Id { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        [Required]
        public int MakeId { get; set; }

        public Make Make { get; set; }

        [Required]
        public int ModelId { get; set; }

        public Model Model { get; set; }

        public int BodyTypeId { get; set; }

        [Required]
        public BodyType BodyType { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [MinLength(GlobalConstants.CarDescriptionMinLength)]
        [MaxLength(GlobalConstants.CarDescriptionMaxLength)]
        public string Description { get; set; }

        public ICollection<CarPicture> CarPictures { get; set; }
        
    }
}
