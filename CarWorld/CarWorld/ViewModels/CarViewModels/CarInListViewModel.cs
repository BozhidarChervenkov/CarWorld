namespace CarWorld.ViewModels.CarViewModels
{
    public class CarInListViewModel
    {
        public int CarId { get; set; }

        public int BodyTypeId { get; set; }

        public string MakeName { get; set; }

        public string ModelName { get; set; }

        public string PictureUrl { get; set; }

        public string Description { get; set; }

        public string ShortDescription => this.Description.Length > 50
            ? this.Description.Substring(0, 50) + "..."
            : this.Description;
    }
}
