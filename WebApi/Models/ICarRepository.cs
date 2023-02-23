using WebApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace WebApi.Models
{
    public interface ICarRepository
    {        
        IEnumerable<Car> GetAll();
        Car Get(int id);
    }
}
