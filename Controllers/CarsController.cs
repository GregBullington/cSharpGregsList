using cSharpGregsList.Services;
using cSharpGregsList.Models;
using Microsoft.AspNetCore.Mvc;

namespace cSharpGregsList.Controllers

{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _cs;
    public CarsController(CarsService cs)
    {
      _cs = cs;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
      try
      {
        List<Car> cars = _cs.Get();
        return Ok(cars);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _cs.Create(newCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Car> Create([FromBody] Car updatedCar, string id, bool pending)
    {
      try
      {
        updatedCar.Id = id;
        Car car = _cs.Update(updatedCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }

    }
    [HttpDelete("pending/{id}")]
    public ActionResult<Car> Pending([FromBody] Car updatedCar, string id, bool pending)
    {
      try
      {
        updatedCar.Id = id;
        updatedCar.Pending = !updatedCar.Pending;
        Car car = _cs.Update(updatedCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<String> Remove(string id)
    {
      try
      {
        _cs.Remove(id);
        return Ok("Removed");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
