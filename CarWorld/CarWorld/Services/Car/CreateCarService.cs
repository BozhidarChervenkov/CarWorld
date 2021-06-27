namespace CarWorld.Services.Car
{
    using System;
    using System.Linq;    
    using Microsoft.AspNetCore.Mvc.Rendering;

    using CarWorld.Data;
    using CarWorld.Models;
    using CarWorld.ViewModels.CreateCarViewModels;

    public class CreateCarService : ICreateCarService
    {
        private readonly ApplicationDbContext context;
        
        public CreateCarService(ApplicationDbContext context)
        {
            this.context = context;
        }

        // TODO: Make method asynchronous
        public void CreateCarAndAddToDb(CreateCarInputModel inputModel, string userId)
        {
            var car = new Car()
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

            this.context.SaveChanges();
        }

        public SelectList BodyTypesSelectList()
        {
            var bodyTypes = this.context.BodyTypes.OrderBy(bt => bt.Name).ToList();

            var selectList = new SelectList(bodyTypes, "Id", "Name");

            return selectList;
        }   
    }
}
