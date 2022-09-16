using FluentAssertions;
using WebApi.App.ActorOperations.Commands.Create;
using WebApi.App.CustomerOperations.Commands.Create;
using WebApi.Entites;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.CustomerOperations.Commands.Create
{
    public class CreateActorCommandValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData("", "", "", "")]
        [InlineData("", "test", "test", "test")]
        [InlineData("test", "", "test", "test")]
        [InlineData("test", "test", "", "test")]
        [InlineData("test", "test", "test", "")]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErorrs(string name, string surName, string email, string password)
        {
            //arrange
            CreateCustomerCommand command = new CreateCustomerCommand(null, null);
            command.Model = new CustomerModel()
            {
                Name = name,
                SurName = surName,
                Email = email,
                Password = password
            };

            //act
            CreateCustomerCommandValidator validator = new CreateCustomerCommandValidator();
            var results = validator.Validate(command);

            //assert
            results.Errors.Count.Should().BeGreaterThan(0);
        }




    }
}