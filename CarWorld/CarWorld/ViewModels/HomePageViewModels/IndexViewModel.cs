namespace CarWorld.ViewModels.HomePageViewModels
{
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;

    public class IndexViewModel
    {
        public ICollection<CarViewModel> Cars { get; set; }   
        
        public string UserId { get; set; }

        [Display(Name = "Message")]

        public string MessageContent { get; set; }
    }
}
