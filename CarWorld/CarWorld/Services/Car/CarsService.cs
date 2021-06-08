namespace CarWorld.Services.Car
{
    using System;
    using System.Linq;    
    using Microsoft.AspNetCore.Mvc.Rendering;

    using CarWorld.Data;
    using CarWorld.Models;
    using CarWorld.ViewModels.CarViewModels;

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
                Pictures=inputModel.Pictures,
            };

            this.context.Cars.Add(car);

            await this.context.SaveChangesAsync();
        }

        public SelectList BodyTypesSelectList()
        {
            var bodyTypes = this.context.BodyTypes.OrderBy(bt => bt.Name).ToList();

            var selectList = new SelectList(bodyTypes, "Id", "Name");

            return selectList;
        }   
    }
}
