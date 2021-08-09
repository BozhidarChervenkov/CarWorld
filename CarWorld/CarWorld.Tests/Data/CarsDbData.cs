namespace CarWorld.Tests.Data
{
    using System.Linq;
    using System.Collections.Generic;

    using CarWorld.Models;

    public static class Cars
    {
        public static IEnumerable<Car> TenCars
            => Enumerable.Range(0, 10).Select(i => new Car
            {
                IsDeleted = false
            });
    }
}
