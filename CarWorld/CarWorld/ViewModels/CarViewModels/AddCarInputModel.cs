namespace CarWorld.ViewModels.CarViewModels
{
    using CarWorld.Models;
    using GlobalConstants;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class AddCarInputModel
    {
        public AddCarInputModel()
        {
            this.Pictures = new HashSet<Picture>();
        }

        [Required]
        public Make Make { get; set; }

        [Required]
        public Model Model { get; set; }

        [Required]
        public int BodyTypeId { get; set; }

        public BodyType BodyType { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [Column(TypeName = GlobalConstants.CarPriceFormat)]
        public decimal Price { get; set; }

        [Required]
        [MinLength(GlobalConstants.CarDescriptionMinLength)]
        [MaxLength(GlobalConstants.CarDescriptionMaxLength)]
        public string Description { get; set; }

        public ICollection<Picture> Pictures { get; set; }
    }
}
