namespace CarWorld.Services.Home
{
    using System.Linq;

    using CarWorld.Data;
    using CarWorld.ViewModels.HomePageViewModels;
  
    public class CountsService : ICountsService
    {
        private ApplicationDbContext context;

        public CountsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public CountsViewModel ReturnCounts()
        {
            CountsViewModel countsViewModel = new()
            {
                CarsCountInDb = context.Cars.Count(c=>c.IsDeleted == false),
                MakesCountInDb = context.Makes.Count(),
                ModelsCountInDb = context.Models.Count(),
                PicturesCountInDb = context.Pictures.Count()
            };

            return countsViewModel;
        }
    }
}
