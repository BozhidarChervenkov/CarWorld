namespace CarWorld.Services.SearchCars
{
    using System.Collections.Generic;

    using CarWorld.ViewModels.HomePageViewModels;

    public interface ISearchService
    {
        bool DoesModelOrNameExist(string searchTerm);

        IEnumerable<CarViewModel> Search(string searchTerm);
    }
}
