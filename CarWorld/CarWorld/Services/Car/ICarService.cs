namespace CarWorld.Services.Car
{
    using CarWorld.ViewModels.CarViewModels;

    public interface ICarService
    {
        CarViewModel Car(int id);
    }
}
