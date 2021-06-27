﻿namespace CarWorld.Services.Categories
{
    using System.Linq;
    using System.Collections.Generic;

    using CarWorld.Data;
    using CarWorld.GlobalConstants;
    using CarWorld.ViewModels.CategoriesViewModels;
    using CarWorld.ViewModels.CarViewModels;

    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext context;

        public CategoryService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public CategoriesInListViewModel Categories()
        {
            var categories = this.context.BodyTypes
                .Select(c=> new CategoryViewModel
                { 
                    Id = c.Id,
                    Name = c.Name,
                    PictureUrl = c.PictureUrl
                })
                .OrderBy(c => c.Name)
                .ToList();

            var viewModel = new CategoriesInListViewModel();
            viewModel.Categories = categories;

            return viewModel;
        }

        public IEnumerable<CarInListViewModel> GetAll(int page, int bodyTypeId, int itemsPerPage = GlobalConstants.MaxCarsPerPageCount)
        {
            // Pagination Logic:
            // 1-12 element: page1
            // 13-24 element: page2
            // 25-36 element: page3
            // Universal pagination formula: (page-1) * itemsPerPage

            var cars = this.context.Cars
                .Where(c=>c.BodyTypeId == bodyTypeId)
                .OrderByDescending(c => c.Id)
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .Select(c => new CarInListViewModel
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
