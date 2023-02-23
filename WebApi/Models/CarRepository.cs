using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;

namespace WebApi.Models
{
    public class CarRepository: ICarRepository
    {
        private readonly AppDbContext _appDbContext;
        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> GetAll()
        {
            return _appDbContext.Cars;
        }
        public Car Get(int id)
        {
            return _appDbContext.Cars.FirstOrDefault(c => c.Id == id);
        }

    }
}
