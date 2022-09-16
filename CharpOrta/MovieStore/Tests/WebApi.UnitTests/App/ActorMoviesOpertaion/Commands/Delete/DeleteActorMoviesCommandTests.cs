using System;
using AutoMapper;
using FluentAssertions;
using WebApi.App.ActorMoviesOperation.Command.Delete;
using WebApi.App.ActorOperations.Commands.Delete;
using WebApi.DbOperations;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.ActorMoviesOpertaion.Commands.Delete
{
    public class DeleteActorMoviesCommandTests: IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public DeleteActorMoviesCommandTests(CommonTestFixture testFixture)
        {
            _dbContext = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Fact]
        public void WhenNotExistActoMovieIsGiven_InvalidOperationException_ShouldBeReturnErrors()
        {
            // Given
            DeleteActorMovieCommand command = new DeleteActorMovieCommand(_dbContext);
            command.Id = 0;
        
            // When // Then
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>()
                .And.Message.Should().Be("ilgili kayda ait veri bulunamadı.");                    
        }

    }
}