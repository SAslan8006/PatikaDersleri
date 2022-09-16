
using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using WebApi.App.ActorMoviesOperation.Command.Create;
using WebApi.App.ActorOperations.Commands.Create;
using WebApi.DbOperations;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.ActorOperations.Commands.Create
{
    public class CreateActorCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateActorCommandTests(CommonTestFixture testFixture)
        {
            _dbContext = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        
        [Fact]
        public void WhenActorModelIsGiven_Create_ShouldBeCreateActor()
        {
            // arrange
            CreateActorModel model = new CreateActorModel() { Name = "testName", SurName = "testSurname"};
            CreateActorCommand command = new CreateActorCommand(_dbContext, _mapper);
            command.Model = model;
        
            // act
            FluentActions
                .Invoking(()=> command.Handle()).Invoke();
        
            // assert
            var actor = _dbContext.Actors.SingleOrDefault(s => s.Name == model.Name && s.SurName == model.SurName);
            
            actor.Should().NotBeNull();
            actor.Name.Should().Be(model.Name);
            actor.SurName.Should().Be(model.SurName);
        }
    }
}