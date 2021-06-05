namespace CarWorld.Services.Car
{
    using System.Collections.Generic;

    using CarWorld.Models;
    using CarWorld.ViewModels.CarViewModels;

    public interface ICarService
    {
        void CreateCarAndAddToDb(AddCarInputModel inputModel);

        ICollection<BodyType> BodyTypesList();
    } 
}
