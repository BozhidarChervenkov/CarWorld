namespace CarWorld.Models
{
    public class CarPicture
    {
        public int CarId { get; set; }

        public Car Car { get; set; }

        public int PictureId { get; set; }

        public Picture Picture { get; set; }
    }
}
