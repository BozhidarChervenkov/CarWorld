namespace CarWorld.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Show
    {
        public Show()
        {
            this.Videos = new HashSet<Video>();
            this.ShowPictures = new HashSet<ShowPicture>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public ICollection<ShowPicture> ShowPictures { get; set; }

        public ICollection<Video> Videos { get; set; }
    }
}
