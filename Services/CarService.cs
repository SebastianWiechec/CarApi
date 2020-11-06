using CarApi.Data;
using CarApi.IServices;
using CarApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Services
{
    public class CarService : ICarService
    {
        ApplicationDbContext dbContext;

        public CarService(ApplicationDbContext _db)
        {
            dbContext = _db;
        }

        public async Task<string> AddCar(Car car)
        {
            dbContext.Car.Add(car);
            await dbContext.SaveChangesAsync();

            return await Task.FromResult("");
        }

        public async Task<string> DeleteCar(int id)
        {
            var car = dbContext.Car.FirstOrDefault(x => x.idCar == id);
            dbContext.Entry(car).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return await Task.FromResult("");
        }

        public async Task<Car> GetCarByIdAsync(string id)
        {
            var car = await dbContext.Car.FindAsync(id);

            if (car == null)
            {

            }

            return car;
        }


        public async Task<IEnumerable<Car>> GetCars()
        {
            return await dbContext.Car.ToListAsync();
        }

        public Car UpdateCar(Car car)
        {
            dbContext.Entry(car).State = EntityState.Modified;
            dbContext.SaveChanges();
            return car;
        }

    }
}
