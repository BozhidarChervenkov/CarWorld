namespace CarWorld.ViewModels.CarShowsViewModels
{
    using System.Collections.Generic;

    using CarWorld.Models;

    public class ShowByIdViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public ICollection<ShowPicture> ShowPictures { get; set; }

        public ICollection<Video> Videos { get; set; }
    }
}
