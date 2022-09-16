using System;
using AutoMapper;
using FluentAssertions;
using WebApi.App.ActorMoviesOperation.Command.Delete;
using WebApi.App.ActorOperations.Commands.Delete;
using WebApi.App.CustomerOperations.Commands.Delete;
using WebApi.DbOperations;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.CustomerOperations.Commands.Delete
{
    public class DeleteCustomerCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public DeleteCustomerCommandTests(CommonTestFixture testFixture)
        {
            _dbContext = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Fact]
        public void WhenNotExistCustomerIdIsGiven_InvalidOperationException_ShouldBeReturnErrors()
        {
            // Given
            DeleteCustomerCommand command = new DeleteCustomerCommand(_dbContext);
            command.Id = 0;
        
            // When // Then
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>()
                .And.Message.Should().Be("Silinmek istenen müşteri bulunamadı.");                    
        }

    }
}