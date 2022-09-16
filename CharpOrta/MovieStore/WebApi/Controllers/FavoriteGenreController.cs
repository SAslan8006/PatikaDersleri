using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.App.FavoritesGenreOperations.Commands.Create;
using WebApi.App.FavoritesGenreOperations.Commands.Delete;
using WebApi.App.FavoritesGenreOperations.Commands.Update;
using WebApi.App.FavoritesGenreOperations.Queries.Get;
using WebApi.App.FavoritesGenreOperations.Queries.GetDetail;
using WebApi.DbOperations;
using static WebApi.App.FavoritesGenreOperations.Commands.Update.UpdateFavoriteGenresCommand;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]s")]
    public class FavoriteGenreController : ControllerBase
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public FavoriteGenreController(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetFavoriteGenres()
        {
            GetFavoritesGenreQuery query = new GetFavoritesGenreQuery(_dbContext, _mapper);
            var response = query.Handle();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetFavoriteGenresDetail(int id)
        {
            GetFavoritesGenreDetailQuery query = new GetFavoritesGenreDetailQuery(_dbContext, _mapper);
            query.Id = id;

            GetFavoritesGenreDetailQueryValidator validator = new GetFavoritesGenreDetailQueryValidator();
            validator.ValidateAndThrow(query);

            var response = query.Handle();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreateFavoriteGenres([FromBody] FavoriteGenresModel model)
        {
            CreateFavoriteGenresCommand command = new CreateFavoriteGenresCommand(_dbContext, _mapper);
            command.model = model;

            CreateFavoriteGenresCommandValidator validator = new CreateFavoriteGenresCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateFavoriteGenres([FromBody] UpdateFavoriteGenresModel model, int Id)
        {
            UpdateFavoriteGenresCommand command = new UpdateFavoriteGenresCommand(_dbContext, _mapper);
            command.model = model;
            command.Id = Id;

            UpdateFavoriteGenresCommandValidator validator = new UpdateFavoriteGenresCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFavoriteGenres(int Id)
        {
            DeleteFavoriteGenresCommand command = new DeleteFavoriteGenresCommand(_dbContext);        
            command.Id = Id;

            DeleteFavoriteGenresCommandValidator validator = new DeleteFavoriteGenresCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }
    }
}