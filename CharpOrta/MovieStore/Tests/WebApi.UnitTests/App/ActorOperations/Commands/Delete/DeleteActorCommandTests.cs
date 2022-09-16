using System;
using AutoMapper;
using FluentAssertions;
using WebApi.App.ActorMoviesOperation.Command.Delete;
using WebApi.App.ActorOperations.Commands.Delete;
using WebApi.DbOperations;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.ActorOperations.Commands.Delete
{
    public class DeleteActorCommandTests: IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public DeleteActorCommandTests(CommonTestFixture testFixture)
        {
            _dbContext = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Fact]
        public void WhenNotExistActoMovieIsGiven_InvalidOperationException_ShouldBeReturnErrors()
        {
            // Given
            DeleteActorCommand command = new DeleteActorCommand(_dbContext);
            command.Id = 0;
        
            // When // Then
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>()
                .And.Message.Should().Be("Silinmek istenen oyuncu bulunamadı.");                    
        }

    }
}