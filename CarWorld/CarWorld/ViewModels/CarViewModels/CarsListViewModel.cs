namespace CarWorld.ViewModels.CarViewModels
{
    using System;
    using System.Collections.Generic;

    public class CarsListViewModel
    {
        public IEnumerable<CarInListViewModel> Cars { get; set; }

        // Needed properties for pagination
        public int PageNumber { get; set; }

        public int ItemsPerPage { get; set; }

        public int DbCarsCount { get; set; }

        // Computing properties using the ones above

        public int PagesCount => (int)Math.Ceiling((double)this.DbCarsCount / this.ItemsPerPage);

        public bool HasPreviousPage => this.PageNumber > 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int PreviousPageNumber => this.PageNumber - 1;

        public int NextPageNumber => this.PageNumber + 1;
    }
}
