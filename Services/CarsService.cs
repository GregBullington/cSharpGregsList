using cSharpGregsList.DB;
using cSharpGregsList.Models;

namespace cSharpGregsList.Services
{
  public class CarsService
  {
    internal List<Car> Get()
    {
      return FakeDB.Cars;
    }
    internal Car Get(string id)
    {
      Car found = FakeDB.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id!");
      }
      return found;
    }
    internal Car Create(Car newCar)
    {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }
    internal Car Update(Car updatedCar)
    {
      Car oldCar = Get(updatedCar.Id);
      oldCar.Make = updatedCar.Make != null ? updatedCar.Make : oldCar.Make;
      oldCar.Model = updatedCar.Model != null ? updatedCar.Model : oldCar.Model;
      oldCar.Year = updatedCar.Year != null ? updatedCar.Year : oldCar.Year;
      oldCar.Price = updatedCar.Price != null ? updatedCar.Price : oldCar.Price;
      oldCar.Description = updatedCar.Description != null ? updatedCar.Description : oldCar.Description;
      oldCar.ImageUrl = updatedCar.ImageUrl != null ? updatedCar.ImageUrl : oldCar.ImageUrl;
      oldCar.Pending = updatedCar.Pending != false ? updatedCar.Pending : oldCar.Pending;
      return oldCar;
    }
    internal void Remove(string id)
    {
      Car car = Get(id);
      FakeDB.Cars.Remove(car);
    }
  }
}