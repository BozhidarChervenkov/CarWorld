namespace CarWorld.ViewModels.CarShowsViewModels
{   
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    using CarWorld.Models;

    using static GlobalConstants.GlobalConstants;

    public class AddShowInputModel
    {
        public AddShowInputModel()
        {
            this.ShowPictures = new HashSet<ShowPicture>();
            this.Videos = new HashSet<Video>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(ShowTitleMinLenght)]
        [MaxLength(ShowTitleMaxLenght)]
        public string Title { get; set; }

        [Required]
        [MinLength(ShowDescriptionMinLenght)]
        [MaxLength(ShowDescriptionMaxLenght)]
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        [DisplayName("Add pictures")]
        public ICollection<ShowPicture> ShowPictures { get; set; }

        [DisplayName("Add videos")]
        public ICollection<Video> Videos { get; set; }
    }
}
