namespace CarWorld.ViewModels.CarViewModels
{
    using static GlobalConstants.GlobalConstants;

    public class CarInListViewModel
    {
        public int CarId { get; set; }

        public int BodyTypeId { get; set; }

        public string MakeName { get; set; }

        public string ModelName { get; set; }

        public string PictureUrl { get; set; }

        public string Description { get; set; }

        public string ShortDescription => this.Description.Length > AllPageCarDescriptionLength
            ? this.Description.Substring(0, AllPageCarDescriptionLength) + "..."
            : this.Description;
    }
}
