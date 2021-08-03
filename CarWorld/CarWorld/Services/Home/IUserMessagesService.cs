namespace CarWorld.Services.Home
{
    using System.Threading.Tasks;

    using CarWorld.ViewModels.HomePageViewModels;
    using CarWorld.Areas.Administration.ViewModels.AdministrationMessages;
    
    public interface IUserMessagesService
    {
        void Save(IndexViewModel model);

        Task<bool> Delete(int id);

        UserMessagesViewModel All();       
    }
}
