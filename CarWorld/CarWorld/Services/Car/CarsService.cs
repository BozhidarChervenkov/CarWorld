namespace CarWorld.Services.Car
{
    using System.Linq;
    using System.Collections.Generic;

    using CarWorld.Data;
    using CarWorld.GlobalConstants;
    using CarWorld.ViewModels.CarViewModels;

    public class CarsService : ICarsService
    {
        private readonly ApplicationDbContext context;

        public CarsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public int DbCarsCount()
        {
            return this.context.Cars.Count();
        }

        public string BodyTypeName(int bodyTypeId)
        {
            return this.context.BodyTypes
                .Where(bt => bt.Id == bodyTypeId)
                .Select(bt => bt.Name)
                .FirstOrDefault();
        }

        public CarViewModel Car(int id)
        {
            // Selection of a single entity with specific columns from database
            var car = this.context.Cars
                               .Where(c=>c.Id == id)
                               .Select(c => new CarViewModel
                               {
                                   Id = c.Id,
                                   Make = c.Make,
                                   Model = c.Model,
                                   BodyType = c.BodyType,
                                   AddedByUser = c.AddedByUser,
                                   Year = c.Year,
                                   Price = c.Price,
                                   VotesCount = c.Votes.Sum(v=>(int)v.Type),
                                   Description = c.Description,
                                   CreatedOn = c.CreatedOn,
                                   Pictures = c.Pictures.ToList(),
                               })
                               .FirstOrDefault();

            return car;
        }

        public IEnumerable<CarInListViewModel> GetAll(int page, int itemsPerPage = GlobalConstants.MaxCarsPerPageCount)
        {
            // Pagination Logic:
            // 1-12 element: page1
            // 13-24 element: page2
            // 25-36 element: page3
            // Universal pagination formula: (page-1) * itemsPerPage

            var cars = this.context.Cars
                .OrderByDescending(c => c.Id)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .Select(c=> new CarInListViewModel
                {
                    CarId = c.Id,
                    BodyTypeId = c.BodyTypeId,
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
