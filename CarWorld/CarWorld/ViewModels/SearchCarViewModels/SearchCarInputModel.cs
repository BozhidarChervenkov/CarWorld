namespace CarWorld.ViewModels.SearchCarViewModels
{
    using System.Collections.Generic;

    using CarWorld.ViewModels.HomePageViewModels;

    public class SearchCarInputModel
    {
        public SearchCarInputModel()
        {
            this.SearchResult = new HashSet<CarViewModel>();
        }

        public string SearchTerm { get; set; }

        public IEnumerable<CarViewModel> SearchResult { get; set; }
    }
}
