namespace CarWorld.Services.SearchCars
{
    using System.Linq;
    using System.Collections.Generic;
    
    using CarWorld.Data;
    using CarWorld.ViewModels.HomePageViewModels;
    
    public class SearchService : ISearchService
    {
        private readonly ApplicationDbContext context;

        public SearchService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool DoesModelOrNameExist(string searchTerm)
        {
            var result = this.context.Cars.Any(c => c.IsDeleted == false && (c.Make.Name.Contains(searchTerm) || c.Model.Name.Contains(searchTerm)));

            return result;
        }

        public IEnumerable<CarViewModel> Search(string searchTerm)
        {
            var cars = this.context.Cars
                .Where(c => c.IsDeleted == false && (c.Make.Name.Contains(searchTerm) || c.Model.Name.Contains(searchTerm)))
                .Select(c => new CarViewModel()
                {
                    CarId = c.Id,
                    MakeName = c.Make.Name,
                    ModelName = c.Model.Name,
                    Description = c.Description,
                    PictureUrl = c.Pictures.FirstOrDefault().Url
                })
                .ToList();

            return cars;
        }
    }
}
