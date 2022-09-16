using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using WebApi.App.ActorMoviesOperation.Command.Create;
using WebApi.App.ActorMoviesOperation.Command.Update;
using WebApi.DbOperations;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.ActorMoviesOpertaion.Commands.Update
{
    public class UpdateActorMoviesCommandTests: IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public UpdateActorMoviesCommandTests(CommonTestFixture testFixture)
        {
            _dbContext = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Fact]
        public void WhenNotExistActorIdInModelIsGiven_InvalidOperationException_ShouldBeReturnError()
        {
            //arrange
            UpdateActorMovieModel model = new UpdateActorMovieModel() { ActorId = 0, MovieId = 1};

            //act
            UpdateActorMovieCommand command = new UpdateActorMovieCommand(_dbContext, _mapper);
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
            UpdateActorMovieModel model = new UpdateActorMovieModel() { ActorId = 1, MovieId = 0};

            //act
            UpdateActorMovieCommand command = new UpdateActorMovieCommand(_dbContext, _mapper);
            command.model = model;
            

            //assert
            FluentActions
                .Invoking(()=> command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Film bulunamadı");
        }

        [Fact]
        public void WhenNotExistActorMovieIdIsGiven_InvalidOperationException_ShouldBeReturnError()
        {
            //arrange
            UpdateActorMovieCommand command = new UpdateActorMovieCommand(_dbContext, _mapper);
            UpdateActorMovieModel model = new UpdateActorMovieModel() { ActorId = 1, MovieId = 1};
            command.model = model;           
             
            //act
            command.Id = 0;
            
            //assert
            FluentActions
                .Invoking(()=> command.Handle())
                .Should().Throw<InvalidOperationException>()
                .And.Message.Should().Be("ilgili kayda ait veri bulunamadı.");
        }

        [Fact]
        public void WhenNotExistMovieAndActorIdIsGiven_Update_ShouldBeUpdateActorMovies()
        {
            // arrange
            UpdateActorMovieModel model = new UpdateActorMovieModel() { ActorId = 3, MovieId = 4};
            UpdateActorMovieCommand command = new UpdateActorMovieCommand(_dbContext, _mapper);
            command.model = model;
            command.Id = 1;
        
            // act
            FluentActions
                .Invoking(()=> command.Handle()).Invoke();
        
            // assert
            var actorMovies = _dbContext.ActorMovies.SingleOrDefault(s => s.Id == 1);
            
            actorMovies.Should().NotBeNull();
            actorMovies.ActorId.Should().Be(model.ActorId);
            actorMovies.MovieId.Should().Be(model.MovieId);
        }

    }
}