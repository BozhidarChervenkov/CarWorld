namespace CarWorld.ViewModels.CarViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using CarWorld.Models;

    using static CarWorld.GlobalConstants.GlobalConstants;

    public class CarEditViewModel
    {
        public CarEditViewModel()
        {
            this.Pictures = new HashSet<Picture>();
        }

        public int CarId { get; set; }

        [Required]
        public Make Make { get; set; }

        [Required]
        public Model Model { get; set; }

        [Required]
        public int BodyTypeId { get; set; }

        [Display(Name = "Body Type")]
        public BodyType BodyType { get; set; }

        [Required]
        [Range(CarYearMin, CarYearMax)]
        public int Year { get; set; }

        [Required]
        [Column(TypeName = CarPriceFormat)]
        public decimal Price { get; set; }

        [Required]
        [MinLength(CarDescriptionMinLength)]
        [MaxLength(CarDescriptionMaxLength)]
        public string Description { get; set; }

        public ICollection<Picture> Pictures { get; set; }
    }
}
