namespace CarWorld.ViewModels.CarViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class CarCommentViewModel
    {
        [Required]
        public int CarId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int MainCommentId { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
