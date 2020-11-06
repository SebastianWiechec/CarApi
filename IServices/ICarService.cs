using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarApi.Models;

namespace CarApi.IServices
{
    public interface ICarService
    {
        Task<IEnumerable<Car>> GetCars();
        Task<Car> GetCarByIdAsync(string IdCar);
        Task<string> AddCar(Car car);
        Car UpdateCar(Car car);
        Task<string> DeleteCar(int IdCar);

    }
}
