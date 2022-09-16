
using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using WebApi.App.ActorMoviesOperation.Command.Create;
using WebApi.DbOperations;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.ActorMoviesOpertaion.Commands.Create
{
    public class CreateActorMoviesCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateActorMoviesCommandTests(CommonTestFixture testFixture)
        {
            _dbContext = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Fact]
        public void WhenNotExistActorIdInModelIsGiven_InvalidOperationException_ShouldBeReturnError()
        {
            //arrange
            CreateActorMovieModel model = new CreateActorMovieModel() { ActorId = 0, MovieId = 1};

            //act
            CreateActorMoviesCommand command = new CreateActorMoviesCommand(_dbContext, _mapper);
            command.model = model;
            

            //assert
            FluentActions
                .Invoking(()=> command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Oyuncu bulunamadı");
        }

        [Fact]
        public void WhenNotExistMovieIdInModelIsGiven_InvalidOperationException_ShouldBeReturnError()
        {
            //arrange
            CreateActorMovieModel model = new CreateActorMovieModel() { ActorId = 1, MovieId = 0};

            //act
            CreateActorMoviesCommand command = new CreateActorMoviesCommand(_dbContext, _mapper);
            command.model = model;
            

            //assert
            FluentActions
                .Invoking(()=> command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Film bulunamadı");
        }

        [Fact]
        public void WhenAlreadyExistMovieAndActorIdInModelIsGiven_InvalidOperationException_ShouldBeReturnError()
        {
            //arrange
            CreateActorMovieModel model = new CreateActorMovieModel() { ActorId = 1, MovieId = 1};

            //act
            CreateActorMoviesCommand command = new CreateActorMoviesCommand(_dbContext, _mapper);
            command.model = model;
            
            //assert
            FluentActions
                .Invoking(()=> command.Handle())
                .Should().Throw<InvalidOperationException>()
                .And.Message.Should().Be("Oyuncu, daha önce bu filmde oynamış.");
        }

        [Fact]
        public void WhenNotExistMovieAndActorIdIsGiven_Create_ShouldBeCreateActorMovies()
        {
            // arrange
            CreateActorMovieModel model = new CreateActorMovieModel() { ActorId = 3, MovieId = 4};
            CreateActorMoviesCommand command = new CreateActorMoviesCommand(_dbContext, _mapper);
            command.model = model;
        
            // act
            FluentActions
                .Invoking(()=> command.Handle()).Invoke();
        
            // assert
            var actorMovies = _dbContext.ActorMovies.SingleOrDefault(s => s.ActorId == model.ActorId && s.MovieId == model.MovieId);
            
            actorMovies.Should().NotBeNull();
            actorMovies.ActorId.Should().Be(model.ActorId);
            actorMovies.MovieId.Should().Be(model.MovieId);
        }
    }
}