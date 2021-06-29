namespace CarWorld.ViewModels.CarViewModels
{
    using System;
    using System.Collections.Generic;

    using CarWorld.Models;

    public class CarViewModel
    {
        public CarViewModel()
        {
            this.Pictures = new List<Picture>();
        }
        public int Id { get; set; }

        public Make Make { get; set; }

        public Model Model { get; set; }

        public BodyType BodyType { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public int VotesCount {get; set;}

        public DateTime CreatedOn { get; set; }

        public List<Picture> Pictures { get; set; }

    }
}
