using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.App.ActorMoviesOperation.Command.Create;
using WebApi.App.ActorMoviesOperation.Command.Delete;
using WebApi.App.ActorMoviesOperation.Command.Update;
using WebApi.App.ActorMoviesOperation.Queries.Get;
using WebApi.App.ActorMoviesOperation.Queries.GetDetail;
using WebApi.DbOperations;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]s")]
    public class ActorMovieController : ControllerBase
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public ActorMovieController(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetActorMovie()
        {
            GetActorMoviesQuery query = new GetActorMoviesQuery(_dbContext, _mapper);
            var response = query.Handle();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetActorMovie(int id)
        {
            GetActorMoviesDetailQuery query = new GetActorMoviesDetailQuery(_dbContext, _mapper);
            query.Id = id;

            GetActorMoviesDetailQueryValidator validator = new GetActorMoviesDetailQueryValidator();
            validator.ValidateAndThrow(query);

            var response = query.Handle();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreateActorMovie([FromBody] CreateActorMovieModel model)
        {
            CreateActorMoviesCommand command = new CreateActorMoviesCommand(_dbContext, _mapper);
            command.model = model;

            CreateActorMoviesCommandValidator validator = new CreateActorMoviesCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateActorMovie([FromBody] UpdateActorMovieModel model, int Id)
        {
            UpdateActorMovieCommand command = new UpdateActorMovieCommand(_dbContext, _mapper);
            command.model = model;
            command.Id = Id;

            UpdateActorMovieCommandValidator validator = new UpdateActorMovieCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteActorMovie(int Id)
        {
            DeleteActorMovieCommand command = new DeleteActorMovieCommand(_dbContext);        
            command.Id = Id;

            DeleteActorMovieCommandValidator validator = new DeleteActorMovieCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }
    }

}