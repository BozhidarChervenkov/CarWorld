namespace CarWorld.Services.Car
{
    using CarWorld.Data;
    using CarWorld.Models;
    using CarWorld.ViewModels.CarViewModels;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Linq;

    public class CarsService : ICarService
    {
        private readonly ApplicationDbContext context;
        
        public CarsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async void CreateCarAndAddToDb(AddCarInputModel inputModel, string userId)
        {
            Car car = new()
            {
                Make = inputModel.Make,
                Model = inputModel.Model,
                BodyTypeId = inputModel.BodyTypeId,
                Year = inputModel.Year,
                Price = inputModel.Price,
                Description = inputModel.Description,
                CreatedOn = DateTime.Now,
                AddedByUserId = userId,
            };

            //this.context.Cars.Add(car);

            //await this.context.SaveChangesAsync();
        }

        public SelectList BodyTypesSelectList()
        {
            var bodyTypes = this.context.BodyTypes.OrderBy(bt => bt.Name).ToList();

            var selectList = new SelectList(bodyTypes, "Id", "Name");

            return selectList;
        }

        
    }
}
