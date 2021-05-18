using System;
using System.Collections.Generic;
using gregslist_cs.Models;
using gregslist_cs.Services;
using Microsoft.AspNetCore.Mvc;

namespace gregslist_cs.Controllers
{

        [ApiController]
        [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarsService _service;

        public CarsController(CarsService service)
        {
            _service = service;
        }

[HttpGet]
        public ActionResult<IEnumerable<Car>> GetAll()
        {
            try
            {
                IEnumerable<Car> cars = _service.GetAll();
                return Ok(cars);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

[HttpGet("{id}")]
        public ActionResult<Car> GetById(string id)
        {
            try
            {
                Car found = _service.GetById(id);
                return Ok(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
[HttpPost]
public ActionResult<Car> CreateCar([FromBody] Car newCar)
{
    try
    {
        Car car = _service.CreateCar(newCar);
        return(car);
    }
    catch (Exception e)
    {
        return BadRequest(e.Message);
    }
}

[HttpDelete("{id}")]
public ActionResult<String> deleteCar(string id)
{
    try
    {
        _service.deleteCar(id);
        return "Successfully Deleted";
    }
    catch (Exception e)
    {
        return BadRequest(e.Message);
    }
}

[HttpPut("{id}")]
public ActionResult<Car> EditCar([FromBody] Car newCar, string id)
{
try
{
    newCar.Id = id;
    Car car = _service.EditCar(newCar);
    return car;
}
catch (Exception e)
{
    return BadRequest(e.Message);
}
}





    }



}