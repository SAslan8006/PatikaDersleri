using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using WebApi.App.ActorMoviesOperation.Command.Create;
using WebApi.App.ActorMoviesOperation.Command.Update;
using WebApi.App.ActorOperations.Commands.Update;
using WebApi.DbOperations;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.ActorOperations.Commands.Update
{
    public class UpdateActorCommandTests: IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public UpdateActorCommandTests(CommonTestFixture testFixture)
        {
            _dbContext = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Fact]
        public void WhenNotExistActorIdInModelIsGiven_InvalidOperationException_ShouldBeReturnError()
        {
            //arrange
            UpdateActorModel model = new UpdateActorModel() { Name = "test", SurName = "test"};

            //act
            UpdateActorCommand command = new UpdateActorCommand(_dbContext);
            command.Model = model;
            
            //assert
            FluentActions
                .Invoking(()=> command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Oyuncu bulunamadı.");
        }

              
        [Fact]
        public void WhenAlreadyExistActorIdAndModelAreGiven_Update_ShouldBeUpdateActorMovies()
        {
            // arrange
            UpdateActorModel model = new UpdateActorModel() { Name = "test", SurName = "test"};
            UpdateActorCommand command = new UpdateActorCommand(_dbContext);
            command.Model = model;
            command.Id = 1;
        
            // act
            FluentActions
                .Invoking(()=> command.Handle()).Invoke();
        
            // assert
            var actor = _dbContext.Actors.SingleOrDefault(s => s.Id == 1);
            
            actor.Should().NotBeNull();
            actor.Name.Should().Be(model.Name);
            actor.SurName.Should().Be(model.SurName);
        }

    }
}