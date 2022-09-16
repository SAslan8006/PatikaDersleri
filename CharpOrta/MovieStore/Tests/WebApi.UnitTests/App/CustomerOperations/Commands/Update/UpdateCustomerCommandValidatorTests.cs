using System.Runtime.InteropServices;
using FluentAssertions;
using WebApi.App.ActorMoviesOperation.Command.Update;
using WebApi.App.CustomerOperations.Commands.Create;
using WebApi.App.CustomerOperations.Commands.Update;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.CustomerOperations.Commands.Update
{
    public class UpdateActorMoviesCommandValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData(0, "testName", "testSurname", "testEmail@gmail.com", "testPassword")]
        [InlineData(1, "", "testSurname", "testEmail@gmail.com", "testPassword")]
        [InlineData(1, "testName", "", "testEmail@gmail.com", "testPassword")]
        [InlineData(1, "testName", "testSurname", "", "testPassword")]
        [InlineData(1, "testName", "testSurname", "testEmail@gmail.com", "")]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErorrs(int customerId, string name, string surName, string email, string password)
        {
            //arrange
            UpdateCustomerCommand command = new UpdateCustomerCommand(null);
            command.Model = new CustomerModel()
            {
                Name = name,
                SurName = surName,
                Email = email,
                Password = password
            };
            command.Id = customerId;

            //act
            UpdateCustomerCommandValidator validator = new UpdateCustomerCommandValidator();
            var results = validator.Validate(command);

            //assert
            results.Errors.Count.Should().BeGreaterThan(0);
        }

        [Theory]
        [InlineData(1, "testName", "testSurname", "testEmail@gmail.com", "testPassword")]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErorrs(int customerId, string name, string surName, string email, string password)
        {
            //arrange
            UpdateCustomerCommand command = new UpdateCustomerCommand(null);
            command.Model = new CustomerModel()
            {
                Name = name,
                SurName = surName,
                Email = email,
                Password = password
            };
            command.Id = customerId;

            //act
            UpdateCustomerCommandValidator validator = new UpdateCustomerCommandValidator();
            var results = validator.Validate(command);

            //assert
            results.Errors.Count.Should().BeLessThanOrEqualTo(0);
        }
    }
}