using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.App.DirectorMoviesOperation.Commands.Create;
using WebApi.App.DirectorMoviesOperation.Commands.Delete;
using WebApi.App.DirectorMoviesOperation.Commands.Update;
using WebApi.App.DirectorMoviesOperation.Queries.Get;
using WebApi.App.DirectorMoviesOperation.Queries.GetDetail;
using WebApi.DbOperations;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]s")]
    public class DirectorMovieController : ControllerBase
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public DirectorMovieController(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetActorMovie()
        {
            GetDirectorMoviesQuery query = new GetDirectorMoviesQuery(_dbContext, _mapper);
            var response = query.Handle();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetActorMovie(int id)
        {
            GetDirectorMovieDetailQuery query = new GetDirectorMovieDetailQuery(_dbContext, _mapper);
            query.Id = id;

            GetDirectorMovieDetailQueryValidator validator = new GetDirectorMovieDetailQueryValidator();
            validator.ValidateAndThrow(query);

            var response = query.Handle();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreateDirectorMovie([FromBody] DirectorMovieModel model)
        {
            CreateDirectorMovieCommand command = new CreateDirectorMovieCommand(_dbContext, _mapper);
            command.model = model;

            CreateDirectorMovieCommandValidator validator = new CreateDirectorMovieCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDirectorMovie([FromBody] DirectorMovieModel model, int Id)
        {
            UpdateDirectorMovieCommand command = new UpdateDirectorMovieCommand(_dbContext, _mapper);
            command.model = model;
            command.Id = Id;

            UpdateDirectorMovieCommandValidator validator = new UpdateDirectorMovieCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDirectorMovie(int Id)
        {
            DeleteDirectorMovieCommand command = new DeleteDirectorMovieCommand(_dbContext);        
            command.Id = Id;

            DeleteDirectorMovieCommandValidator validator = new DeleteDirectorMovieCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }
    }
}