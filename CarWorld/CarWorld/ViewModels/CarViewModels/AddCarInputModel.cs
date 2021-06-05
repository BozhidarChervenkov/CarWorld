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
            this.CarPictures = new HashSet<CarPicture>();
        }

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
        [Column(TypeName = GlobalConstants.CarPriceFormat)]
        public decimal Price { get; set; }

        [Required]
        [MinLength(GlobalConstants.CarDescriptionMinLength)]
        [MaxLength(GlobalConstants.CarDescriptionMaxLength)]
        public string Description { get; set; }

        public ICollection<CarPicture> CarPictures { get; set; }
    }
}
