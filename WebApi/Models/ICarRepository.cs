using WebApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAll();
        Task<Car> Get(int id);
        Task<Car> Add(Car car);
        Task<Car> Put(int id, Car car);
        Task<Car> Delete(int id);
    }
}
