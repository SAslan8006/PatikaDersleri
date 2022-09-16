using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using WebApi.App.ActorMoviesOperation.Command.Create;
using WebApi.App.ActorMoviesOperation.Command.Update;
using WebApi.App.ActorOperations.Commands.Update;
using WebApi.App.CustomerOperations.Commands.Create;
using WebApi.App.CustomerOperations.Commands.Update;
using WebApi.DbOperations;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.CustomerOperations.Commands.Update
{
    public class UpdateCustomerCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public UpdateCustomerCommandTests(CommonTestFixture testFixture)
        {
            _dbContext = testFixture.Context;
            _mapper = testFixture.Mapper;
        }

        [Fact]
        public void WhenNotExistCustomerIdIsGiven_InvalidOperationException_ShouldBeReturnError()
        {
            //arrange
            CustomerModel model = new CustomerModel() { Name = "testName", SurName = "testSurname" , Email = "test@gmail.com", Password = "test"};

            //act
            UpdateCustomerCommand command = new UpdateCustomerCommand(_dbContext);
            command.Model = model;
            command.Id = 0;
            
            //assert
            FluentActions
                .Invoking(()=> command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Müşteri bulunamadı.");
        }

              
        [Fact]
        public void WhenAlreadyExistCustomerIdAndModelAreGiven_Update_ShouldBeUpdateActorMovies()
        {
            // arrange
            CustomerModel model = new CustomerModel() { Name = "testName", SurName = "testSurname" , Email = "test@gmail.com", Password = "test"};
            UpdateCustomerCommand command = new UpdateCustomerCommand(_dbContext);
            command.Model = model;
            command.Id = 1;
        
            // act
            FluentActions
                .Invoking(()=> command.Handle()).Invoke();
        
            // assert
            var customer = _dbContext.Customers.SingleOrDefault(s => s.Id == 1);
            
            customer.Should().NotBeNull();
            customer.Name.Should().Be(model.Name);
            customer.SurName.Should().Be(model.SurName);
            customer.Email.Should().Be(model.Email);
            customer.Password.Should().Be(model.Password);
        }

    }
}