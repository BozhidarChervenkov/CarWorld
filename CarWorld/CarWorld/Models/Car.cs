namespace CarWorld.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static GlobalConstants.GlobalConstants;

    public class Car
    {
        public Car()
        {
            this.Pictures = new HashSet<Picture>();
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
        [Column(TypeName = CarPriceFormat)]
        public decimal Price { get; set; }

        [Required]
        [MinLength(CarDescriptionMinLength)]
        [MaxLength(CarDescriptionMaxLength)]
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public ICollection<Picture> Pictures { get; set; }        
    }
}
