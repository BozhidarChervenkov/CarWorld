namespace CarWorld.Services.Car
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using CarWorld.GlobalConstants;
    using CarWorld.ViewModels.CarViewModels;

    public interface ICarsService
    {
        int DbCarsCount();

        public string BodyTypeName(int bodyTypeId);

        CarViewModel Car(int id);

        Task<bool> DeleteCar(int id);

        IEnumerable<CarInListViewModel> GetAll (int page, int itemsPerPage = GlobalConstants.MaxCarsPerPageCount);
    }
}
