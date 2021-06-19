namespace CarWorld.ViewModels.CarViewModels
{
    using System.Collections.Generic;

    public class CarsListViewModel : PagingViewModel
    {
        public IEnumerable<CarInListViewModel> Cars { get; set; }
    }
}
