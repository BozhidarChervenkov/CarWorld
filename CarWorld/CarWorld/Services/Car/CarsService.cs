﻿namespace CarWorld.Services.Car
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

        public IEnumerable<CarInListViewModel> GetAll(int page, int itemsPerPage = GlobalConstants.MaxCarsPerPageCount)
        {
            // Pagination Logic:
            // 1-12 element: page1
            // 13-24 element: page2
            // 25-36 element: page3
            // Universal pagination formula: (page-1) * itemsPerPage

            IEnumerable<CarInListViewModel> cars = this.context.Cars
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
