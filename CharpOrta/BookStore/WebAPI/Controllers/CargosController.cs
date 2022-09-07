using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargosController : ControllerBase
    {
        ICargoService _cargoService;

        public CargosController(ICargoService cargoService)
        {
            _cargoService = cargoService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _cargoService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyname")]
        public IActionResult GetByName(string cargo)
        {
            var result = _cargoService.GetByName(cargo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Cargo cargo)
        {
            var result = _cargoService.Add(cargo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Cargo cargo)
        {
            var result = _cargoService.Update(cargo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Cargo cargo)
        {
            var result = _cargoService.Delete(cargo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
