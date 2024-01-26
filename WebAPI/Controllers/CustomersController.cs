using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _customerService.GetCustomerById(id);
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }

        [HttpGet("getbyuser")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _customerService.GetCustomerByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Customer user)
        {
            var result = _customerService.Add(user);
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customer user)
        {
            var result = _customerService.Delete(user);
            if (result.Success) { return Ok( result); }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Customer user)
        {
            var result = _customerService.Delete(user);
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }

    }
}
