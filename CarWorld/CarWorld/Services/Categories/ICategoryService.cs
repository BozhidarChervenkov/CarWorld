namespace CarWorld.Services.Categories
{
    using System.Collections.Generic;

    using CarWorld.ViewModels.CarViewModels;
    using CarWorld.ViewModels.CategoriesViewModels;

    public interface ICategoryService
    {
        CategoriesInListViewModel Categories();

        IEnumerable<CarInListViewModel> GetAll(int page, int bodyTypeId, int itemsPerPage);
    }
}
