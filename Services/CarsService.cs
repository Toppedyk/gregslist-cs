using System;
using System.Collections.Generic;
using gregslist_cs.DB;
using gregslist_cs.Models;

namespace gregslist_cs.Services
{
    public class CarsService
    {
        public IEnumerable<Car> GetAll()
        {
            return FakeDB.Cars;
        }

    internal Car GetById(string id)
    {
      Car found = FakeDB.Cars.Find(c => c.Id == id);
      if(found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Car CreateCar(Car newCar)
    {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }

    internal void deleteCar(string id)
    {
      Car car = GetById(id);
      FakeDB.Cars.Remove(car);
    }

    internal Car EditCar(Car newCar)
    {
      Car oldCar = GetById(newCar.Id);
      oldCar.Make = newCar.Make;
      oldCar.Model = newCar.Model;
      oldCar.Description = newCar.Description;
      oldCar.ImgUrl = newCar.ImgUrl;
      oldCar.Year = newCar.Year;
      oldCar.Price = newCar.Price;
      
      return oldCar;
    }
  }


}