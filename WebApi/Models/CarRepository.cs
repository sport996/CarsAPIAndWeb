using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;

namespace WebApi.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _db;
        public CarRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public async Task<IEnumerable<Car>> GetAll()
        {
            return await _db.Cars.ToListAsync();
        }
        public async Task<Car> Get(int id)
        {
            return await _db.Cars.FindAsync(id);
        }
        public async Task<Car> Add(Car car)
        {
            var result = _db.Add(car);
            await _db.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Car> Put(int id, Car car)
        {
            _db.Entry(car).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return car;
        }
        public async Task<Car> Delete(int id)
        {
            var car = _db.Cars.FindAsync(id);
            _db.Cars.Remove(await car);
            await _db.SaveChangesAsync();
            return await car;
        }
        //private bool CarExists(int id)
        //{
        //    return _db.Cars.Any(e => e.Id == id);
        //}
    }
}
