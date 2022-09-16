using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.App.CustomerOperations.Queries.Get;
using WebApi.App.PurchasedMoviesOperation.Commands.Create;
using WebApi.App.PurchasedMoviesOperation.Commands.Delete;
using WebApi.App.PurchasedMoviesOperation.Commands.Update;
using WebApi.App.PurchasedMoviesOperation.Queries.Get;
using WebApi.App.PurchasedMoviesOperation.Queries.GetDetail;
using WebApi.DbOperations;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]s")]
    public class PurchasedMovieController : ControllerBase
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public PurchasedMovieController(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetPurchasedMovies()
        {
            GetPurchasedMoviesQuery query = new GetPurchasedMoviesQuery(_dbContext, _mapper);
            var response = query.Handle();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetPurchasedMoviesDetail(int id)
        {
            GetPurchasedMoviesDetailQuery query = new GetPurchasedMoviesDetailQuery(_dbContext, _mapper);
            query.Id = id;

            GetPurchasedMoviesDetailQueryValidator validator = new GetPurchasedMoviesDetailQueryValidator();
            validator.ValidateAndThrow(query);

            var response = query.Handle();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreatePurchasedMovie([FromBody] PurchasedMoviesModel model)
        {
            CreatePurchaseMovieCommand command = new CreatePurchaseMovieCommand(_dbContext, _mapper);
            command.model = model;

            CreatePurchaseMovieCommandValidator validator = new CreatePurchaseMovieCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePurchasedMovie([FromBody] PurchasedMoviesModel model, int Id)
        {
            UpdatePurchaseMovieCommand command = new UpdatePurchaseMovieCommand(_dbContext, _mapper);
            command.model = model;
            command.Id = Id;

            UpdatePurchaseMovieCommandValidator validator = new UpdatePurchaseMovieCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDirectorMovie(int Id)
        {
            DeletePurchasedMovieCommand command = new DeletePurchasedMovieCommand(_dbContext);        
            command.Id = Id;

            DeletePurchasedMovieCommandValidator validator = new DeletePurchasedMovieCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }
    }
}