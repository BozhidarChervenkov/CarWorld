namespace CarWorld.Services.Home
{
    using System.Linq;
    using System.Collections.Generic;

    using CarWorld.Data;
    using CarWorld.ViewModels.HomePageViewModels;
    
    public class LatestCarsService : ILatestCarsService
    {
        private readonly ApplicationDbContext context;

        public LatestCarsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public LatestCars CollectData()
        {
            // Selection of a list of entities with specific columns from database
            ICollection<CarViewModel> cars = this.context.Cars
                                      .OrderByDescending(c => c.CreatedOn)
                                      .Select(c => new CarViewModel()
                                      {
                                          CarId = c.Id,
                                          MakeName = c.Make.Name,
                                          ModelName= c.Model.Name,
                                          Description = c.Description,
                                          PictureUrl = c.Pictures.FirstOrDefault().Url
                                      })
                                      .Take(8)
                                      .ToList();

            // Giving the collection of CarViewModel to main view model for Home page
            LatestCars viewModel = new LatestCars();
            viewModel.Cars = cars;

            return viewModel;
        }
    }
}
