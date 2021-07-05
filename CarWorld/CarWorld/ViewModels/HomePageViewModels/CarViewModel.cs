namespace CarWorld.ViewModels.HomePageViewModels
{
    using static GlobalConstants.GlobalConstants;

    public class CarViewModel
    {
        public int CarId { get; set; }

        public string MakeName { get; set; }

        public string ModelName { get; set; }

        public string Description { get; set; }

        public string ShortDescription => this.Description.Length > HomeCarDescriptionLength
            ? this.Description.Substring(0, HomeCarDescriptionLength) + "..."
            : this.Description;

        public string PictureUrl { get; set; }
    }
}
