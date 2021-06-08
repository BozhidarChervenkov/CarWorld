namespace CarWorld.Services.Car
{
    using Microsoft.AspNetCore.Mvc.Rendering;

    using CarWorld.ViewModels.CarViewModels;

    public interface ICarService
    {
        void CreateCarAndAddToDb(AddCarInputModel inputModel, string userId);

        SelectList BodyTypesSelectList();
    } 
}
