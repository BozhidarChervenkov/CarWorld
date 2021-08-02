namespace CarWorld.Services.Home
{
    using System.Linq;

    using CarWorld.Data;
    using CarWorld.ViewModels.HomePageViewModels;

    using static GlobalConstants.GlobalConstants;

    public class LatestCarsService : ILatestCarsService
    {
        private readonly ApplicationDbContext context;

        public LatestCarsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IndexViewModel CollectData()
        {
            // Selection of a list of entities with specific columns from database
            var cars = this.context.Cars
                                      .Where(c=>c.IsDeleted == false)
                                      .OrderByDescending(c => c.CreatedOn)
                                      .Select(c => new CarViewModel()
                                      {
                                          CarId = c.Id,
                                          MakeName = c.Make.Name,
                                          ModelName= c.Model.Name,
                                          Description = c.Description,
                                          PictureUrl = c.Pictures.FirstOrDefault().Url
                                      })
                                      .Take(HomeCarsPerPage)
                                      .ToList();

            // Giving the collection of CarViewModel to main view model for Home page
            var viewModel = new IndexViewModel();
            viewModel.Cars = cars;

            return viewModel;
        }
    }
}
