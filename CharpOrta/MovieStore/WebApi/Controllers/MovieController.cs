using System.ComponentModel.Design;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.App.MovieOperations.Commands.Create;
using WebApi.App.MovieOperations.Commands.Delete;
using WebApi.App.MovieOperations.Commands.Update;
using WebApi.App.MovieOperations.Queries.Get;
using WebApi.App.MovieOperations.Queries.GetDetail;
using WebApi.DbOperations;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]s")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public MovieController(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetMovie()
        {
            GetMovieQuery query = new GetMovieQuery(_context,_mapper);
            var response = query.Handle();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieDetail(int id)
        {
            GetMovieDetailQuery query = new GetMovieDetailQuery(_context,_mapper);
            query.Id = id;

            GetMovieDetailQueryValidator validator = new GetMovieDetailQueryValidator();
            validator.ValidateAndThrow(query);
            
            var result = query.Handle();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult CrateMovie([FromBody] CreateMovieModel model)
        {
            CreateMovieCommand command = new CreateMovieCommand(_context,_mapper);
            command.Model = model;

            CreateMovieCommandValidator validator = new CreateMovieCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();
            
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie([FromBody] UpdateMovieModel model, int id)
        {
            UpdateMovieCommand command = new UpdateMovieCommand(_context);
            command.Model = model;
            command.Id = id;

            UpdateMovieCommandValidator validator = new UpdateMovieCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            DeleteMovieCommand command = new DeleteMovieCommand(_context);
            command.Id = id;

            DeleteMovieCommandValidator validator = new DeleteMovieCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

    }
    
}