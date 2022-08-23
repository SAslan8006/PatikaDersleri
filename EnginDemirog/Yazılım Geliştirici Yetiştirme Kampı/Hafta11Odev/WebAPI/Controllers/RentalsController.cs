using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {

        IRentalService _rentalService;

            public RentalsController(IRentalService rentalService)
            {
                _rentalService = rentalService;
            }

            [HttpGet("getall")]
            public IActionResult GetAll()
            {
                var result = _rentalService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpGet("getbyid")]
            public IActionResult GetById(int id)
            {
                var result = _rentalService.GetById(id);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpGet("getrentaldetailbycarid")]
            public IActionResult GetRentalDetailByCarId(int carId)
            {
                var result = _rentalService.GetRentalDetailByCarId(carId);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result.Message);
            }

            [HttpGet("getrentaldetailbyuserid")]
            public IActionResult GetRentalDetailByUserId(int userId)
            {
                var result = _rentalService.GetRentalsDetailByUserId(userId);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result.Message);
            }

            [HttpGet("getbycarid")]
            public IActionResult GetByCarId(int id)
            {
                var result = _rentalService.GetByCarId(id);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpPost("add")]
            public IActionResult Add(Rental rental)
            {
                var result = _rentalService.Add(rental);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpPost("update")]
            public IActionResult Update(Rental rental)
            {
                var result = _rentalService.Update(rental);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpDelete("delete")]
            public IActionResult Delete(Rental rental)
            {
                var result = _rentalService.Delete(rental);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpGet("details")]
            public IActionResult GetRentalDetails()
            {
                var result = _rentalService.GetRentalDetails();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
    }
}
