namespace CarWorld.Services.Home
{
    using CarWorld.ViewModels.HomePageViewModels;

    public interface IUserMessagesService
    {
        void Save(IndexViewModel model);
    }
}
