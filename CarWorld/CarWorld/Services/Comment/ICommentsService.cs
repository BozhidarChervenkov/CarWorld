namespace CarWorld.Services.Comment
{
    using CarWorld.ViewModels.CarViewModels;

    public interface ICommentsService
    {
        void CheckCommentTypeAndAddToDb(CarCommentViewModel input); 
    }
}
