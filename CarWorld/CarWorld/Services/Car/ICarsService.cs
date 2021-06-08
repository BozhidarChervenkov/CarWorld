namespace CarWorld.Services.Car
{
    using CarWorld.Models;
    using CarWorld.ViewModels.CarViewModels;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface ICarService
    {
        void CreateCarAndAddToDb(AddCarInputModel inputModel, string userId);

        SelectList BodyTypesSelectList();
    } 
}
