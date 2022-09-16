using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.App.CustomerOperations.Commands.Create;
using WebApi.App.CustomerOperations.Commands.Delete;
using WebApi.App.CustomerOperations.Commands.TokenOperations;
using WebApi.App.CustomerOperations.Commands.Update;
using WebApi.App.CustomerOperations.Queries.Get;
using WebApi.App.CustomerOperations.Queries.GetDetail;
using WebApi.App.DirectorOperations.Commands.Create;
using WebApi.DbOperations;
using WebApi.TokenOperations.Model;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class CustomerController : ControllerBase
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        readonly IConfiguration _configuration;

        public CustomerController(IMovieStoreDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetCustomer()
        {
            GetCustomerQuery query = new GetCustomerQuery(_context, _mapper);
            var result = query.Handle();

            return Ok(result);
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetCustomerDetail(int id)
        {
            GetCustomerQueryDetail query = new GetCustomerQueryDetail(_context, _mapper);
            query.Id = id;

            var result = query.Handle();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateCustomer([FromBody] CustomerModel model)
        {
            CreateCustomerCommand command = new CreateCustomerCommand(_context, _mapper);
            command.Model = model;

            CreateCustomerCommandValidator validator = new CreateCustomerCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [Authorize]
        [HttpPut("{id}")]
        public IActionResult UpdateCustomer([FromBody] CustomerModel model, int id)
        {
            UpdateCustomerCommand command = new UpdateCustomerCommand(_context);
            command.Model = model;
            command.Id = id;

            UpdateCustomerCommandValidator validator = new UpdateCustomerCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeleteActor(int id)
        {
            DeleteCustomerCommand command = new DeleteCustomerCommand(_context);
            command.Id = id;

            DeleteCustomerCommandValidator validator = new DeleteCustomerCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpPost("connect/token")]
        public IActionResult CreateToken([FromBody] CreateTokenModel login)
        {
            CreateTokenCommand command = new CreateTokenCommand(_context, _mapper, _configuration);
            command.Model = login;
            Token token = command.Handle();

            return Ok(token);
        }

        [HttpGet("refreshToken")]
        public IActionResult RefreshToken([FromQuery] string token)
        {
            RefreshTokenCommand command = new RefreshTokenCommand(_context, _configuration);
            command.RefreshToken = token;
            var resultToken = command.Handle();

            return Ok(resultToken);
        }
    }
}