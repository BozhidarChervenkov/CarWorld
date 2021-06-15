namespace CarWorld.Services.Car
{
    using Microsoft.AspNetCore.Mvc.Rendering;

    using CarWorld.ViewModels.CreateCarViewModels;

    public interface ICreateCarService
    {
        void CreateCarAndAddToDb(CreateCarInputModel inputModel, string userId);

        SelectList BodyTypesSelectList();
    } 
}
