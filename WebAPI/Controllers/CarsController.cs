using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            Thread.Sleep(millisecondsTimeout:5
                );

            var result = _carService.GetAll();
            if (result.Success) {return Ok(result); }
            return BadRequest();
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success) { return Ok(result); }
            return BadRequest();
        }

        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        { 
            var result = _carService.GetCarDetails();
            if (result.Success) { return Ok( result); }
            return BadRequest();
        }

        [HttpGet("getcarsbybrandid")] 
        public IActionResult GetCarsByBrandId(int id)
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success) { return Ok(result); }
            return BadRequest();
        }

        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int id)
        {
            var result = _carService.GetCarsByColorId(id);
            if (result.Success) { return Ok(result); }
            return BadRequest();
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success) { return Ok(result); }
            return BadRequest();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success) { return Ok(result); }
            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success) { return Ok( result); }
            return BadRequest();
        }
        
    }
}
