using System;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using WebApi.App.ActorOperations.Commands.Create;
using WebApi.App.CustomerOperations.Commands.Create;
using WebApi.DbOperations;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.CustomerOperations.Commands.Create
{
    public class CreateCustomerCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateCustomerCommandTests(CommonTestFixture testFixture)
        {
            _dbContext = testFixture.Context;
            _mapper = testFixture.Mapper;
        }
        
        [Fact]
        public void WhenAlreadyExistModelIsGiven_InvalidOperationException_ShouldBeReturnError()
        {
            //arrange
            CustomerModel model = new CustomerModel() { Name = "testName", SurName = "testSurname" , Email = "test@gmail.com", Password = "test"};

            //act
            CreateCustomerCommand command = new CreateCustomerCommand(_dbContext, _mapper);
            command.Model = model;
            

            //assert
            FluentActions
                .Invoking(()=> command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kullanıcı zaten mevcut!");
        }
        
        [Fact]
        public void WhenCustomerModelIsGiven_Create_ShouldBeCreateCustomer()
        {
            // arrange
            CustomerModel model = new CustomerModel() { Name = "testName1", SurName = "testSurname1" , Email = "test1@gmail.com", Password = "test1"};
            CreateCustomerCommand command = new CreateCustomerCommand(_dbContext, _mapper);
            command.Model = model;
        
            // act
            FluentActions
                .Invoking(()=> command.Handle()).Invoke();
        
            // assert
            var customer = _dbContext.Customers.SingleOrDefault(s => s.Name == model.Name && s.SurName == model.SurName);
            
            customer.Should().NotBeNull();
            customer.Name.Should().Be(model.Name);
            customer.SurName.Should().Be(model.SurName);
            customer.Email.Should().Be(model.Email);
            customer.Password.Should().Be(model.Password);
        }
    }
}