namespace CarWorld.Services.Home
{
    using CarWorld.ViewModels.HomePageViewModels;
    
    public interface ICountsService
    {
        CountsViewModel ReturnCounts();
    }
}
