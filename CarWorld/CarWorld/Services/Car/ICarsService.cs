namespace CarWorld.Services.Car
{
    using System.Collections.Generic;

    using CarWorld.GlobalConstants;
    using CarWorld.ViewModels.CarViewModels;

    public interface ICarsService
    {
        CarViewModel Car(int id);

        IEnumerable<CarInListViewModel> GetAll (int page, int itemsPerPage = GlobalConstants.MaxCarsPerPageCount);

        int DbCarsCount();
    }
}
