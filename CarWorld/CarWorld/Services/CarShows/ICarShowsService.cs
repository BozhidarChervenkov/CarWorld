namespace CarWorld.Services.CarShows
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using CarWorld.ViewModels.CarShowsViewModels;
    
    public interface ICarShowsService
    {
        IEnumerable<ShowViewModel> AllShows();

        ShowByIdViewModel ShowById(int id);

        void AddShow(AddShowInputModel input, string userId);

        Task<bool> DeleteShow(int id);

        List<string> EmbeddedVideoCodes(ShowByIdViewModel viewModel);
    }
}
