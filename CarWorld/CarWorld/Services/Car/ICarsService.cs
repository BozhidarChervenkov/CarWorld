namespace CarWorld.Services.Car
{
    using System.Threading.Tasks;
    using System.Collections.Generic;
    
    using CarWorld.ViewModels.CarViewModels;

    using static GlobalConstants.GlobalConstants;

    public interface ICarsService
    {
        int DbCarsCount();

        bool DoesCarExist(int id);

        public string BodyTypeName(int bodyTypeId);

        CarViewModel Car(int id);

        CarEditViewModel CarById(int id);

        void Edit(CarEditViewModel input);

        Task<bool> Delete(int id);

        IEnumerable<CarInListViewModel> GetAll (int page, int itemsPerPage = MaxCarsPerPageCount);
    }
}
