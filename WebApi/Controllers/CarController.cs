using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _repository;
        public CarController(ICarRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Cars
        [HttpGet]
        [Route("GetCars")]
        public async Task<IEnumerable<Car>> GetCars()
        {
            return await _repository.GetAll();
        }
        // GET: api/Cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(int id)
        {
            return await _repository.Get(id);
        }
        // POST: api/Cars
        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car car)
        {
            return await _repository.Add(car);
        }
        // PUT: api/Cars/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Car>> PutCar(int id, Car car)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }
            await _repository.Put(id, car);
            return car;
        }
        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Car>> DeleteCar(int id)
        {
            var car = await _repository.Delete(id);
            if (car == null)
            {
                return NotFound();
            }
            return car;
        }
    }
}
