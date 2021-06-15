namespace CarWorld.Services.Car
{
    using System.Linq;

    using CarWorld.Data;
    using CarWorld.ViewModels.CarViewModels;

    public class CarService : ICarService
    {
        private readonly ApplicationDbContext context;

        public CarService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public CarViewModel Car(int id)
        {
            // Selection of a single entity with specific columns from database
            CarViewModel car = this.context.Cars
                               .Where(c=>c.Id == id)
                               .Select(c => new CarViewModel
                               {
                                   Make = c.Make,
                                   Model = c.Model,
                                   BodyType = c.BodyType,
                                   AddedByUser = c.AddedByUser,
                                   Year = c.Year,
                                   Price = c.Price,
                                   Description = c.Description,
                                   CreatedOn = c.CreatedOn,
                                   Pictures = c.Pictures.ToList(),
                               })
                               .FirstOrDefault();

            return car;
        }
    }
}
