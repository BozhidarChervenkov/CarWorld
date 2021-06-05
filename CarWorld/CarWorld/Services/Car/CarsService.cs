namespace CarWorld.Services.Car
{
    using CarWorld.Data;
    using CarWorld.Models;
    using CarWorld.ViewModels.CarViewModels;
    using System.Collections.Generic;
    using System.Linq;

    public class CarsService : ICarService
    {
        private readonly ApplicationDbContext context;

        public CarsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public ICollection<BodyType> BodyTypesList()
        {
            var bodyTypes = this.context.BodyTypes.OrderBy(bt => bt.Id).ToList();

            return bodyTypes;
        }

        public void CreateCarAndAddToDb(AddCarInputModel inputModel)
        {
            Car car = new()
            {
                //Todo:
            };

            this.context.Cars.Add(car);
            this.context.SaveChangesAsync();
        }
    }
}
