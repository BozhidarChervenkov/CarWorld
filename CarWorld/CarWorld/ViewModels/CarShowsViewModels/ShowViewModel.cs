namespace CarWorld.ViewModels.CarShowsViewModels
{
    using System;
    
    public class ShowViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
