using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.App.DirectorOperations.Commands.Create;
using WebApi.App.DirectorOperations.Commands.Delete;
using WebApi.App.DirectorOperations.Commands.Update;
using WebApi.App.DirectorOperations.Queries;
using WebApi.App.DirectorOperations.Queries.Get;
using WebApi.App.DirectorOperations.Queries.GetDetail;
using WebApi.DbOperations;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("[controller]s")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;

        public DirectorController(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            GetDirectorQuery query = new GetDirectorQuery(_dbContext, _mapper);
            List<DirectorQueryViewModel> result = query.Handle();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            GetDirectorQueryDetail query = new GetDirectorQueryDetail(_dbContext, _mapper);
            query.Id = id;

            GetDirectorDetailValidator validator = new GetDirectorDetailValidator();
            validator.ValidateAndThrow(query);

            DirectorQueryViewModel result = query.Handle();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateDirector([FromBody] DirectorModel model)
        {
            CreateDirectorCommand command = new CreateDirectorCommand(_dbContext, _mapper);
            command.model = model;

            CreateDirectorCommandValidator validator = new CreateDirectorCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDirector([FromBody] DirectorModel model, int id)
        {
            UpdateDirectorCommand command = new UpdateDirectorCommand(_dbContext, _mapper);
            command.model = model;
            command.Id = id;

            UpdateDirectorCommandValidator validator = new UpdateDirectorCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDirector(int id)
        {
            DeleteDirectorCommand command = new DeleteDirectorCommand(_dbContext);
            command.Id = id;

            DeleteDirectorCommandValidator validator = new DeleteDirectorCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();

            return Ok();
        }


    }

}