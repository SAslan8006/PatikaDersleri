using FluentAssertions;
using WebApi.App.ActorOperations.Commands.Create;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.App.ActorOperations.Commands.Create
{
    public class CreateActorCommandValidatorTests : IClassFixture<CommonTestFixture>
    {
        [Theory]
        [InlineData("","")]
        [InlineData("","test")]
        [InlineData("test","")]        
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErorrs(string name, string surName)
        {
            //arrange
            CreateActorCommand command = new CreateActorCommand(null,null);
            command.Model = new CreateActorModel()
            {
                Name = name,
                SurName = surName
            };

            //act
            CreateActorCommandValidator validator = new CreateActorCommandValidator();
            var results = validator.Validate(command);

            //assert
            results.Errors.Count.Should().BeGreaterThan(0);
        }

        

        
    }
}