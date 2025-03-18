using Authorization.Data;
using Authorization.Models.Dto;
using Authorization.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {

        private readonly CarsDbContext dbContext;
        public CarsController(CarsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetCars()
        {
            return Ok(dbContext.Cars.ToList());
        }

        [HttpGet]
        [Route("{id:int}")]

        public IActionResult CarById(int id)
        {
            var car= dbContext.Cars.Find(id);
            if(car is null)
            {
                return NotFound();
            }
            return Ok(car);
        }

        [HttpPost]
        public IActionResult AddCar(AddCarDto car)
        {
            var carEntity = new Car()
            {
                Brand = car.Brand,
                Model = car.Model,
                Description = car.Description
            };

            dbContext.Cars.Add(carEntity);
            dbContext.SaveChanges();

            return Ok(carEntity);

        }
    }
}
