namespace CarWorld.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using GlobalConstants;

    public class Picture
    {
        public Picture()
        {
            this.CarPictures = new HashSet<CarPicture>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(GlobalConstants.PictureUrlMinLenght)]
        [MaxLength(GlobalConstants.PictureUrlMaxLenght)]
        public string Url { get; set; }

        public ICollection<CarPicture> CarPictures { get; set; }
    }
}
